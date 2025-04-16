using System;

namespace ConveyorControlSystem
{
    class Program
    {
        static void Main()
        {
            var controller = new ConveyorController();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Conveyor Control ===");

                // Είσοδοι από χρήστη (σαν να ήταν αισθητήρες)
                bool sensorEntry = Ask("SensorEntry active? (y/n): ");
                bool sensorOverload = Ask("SensorOverload active? (y/n): ");
                bool emergencyStop = Ask("EmergencyStop active? (y/n): ");

                // Ενημέρωση εισόδων
                var input = new ConveyorInput
                {
                    SensorEntry = sensorEntry,
                    SensorOverload = sensorOverload,
                    EmergencyStop = emergencyStop
                };

                // Επεξεργασία
                ConveyorOutput output = controller.Process(input);

                // Εμφάνιση εξόδων
                Console.WriteLine("\n>> Outputs:");
                Console.WriteLine($"MotorOn: {(output.MotorOn ? "✅ ON" : "❌ OFF")}");
                Console.WriteLine($"WarningLightOn: {(output.WarningLightOn ? "⚠️ YES" : "🟢 NO")}");

                Console.WriteLine("\nPress any key to try again...");
                Console.ReadKey();
            }
        }

        static bool Ask(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine().ToLower();
            return input == "y" || input == "yes";
        }
    }

    class ConveyorInput
    {
        public bool SensorEntry { get; set; }
        public bool SensorOverload { get; set; }
        public bool EmergencyStop { get; set; }
    }

    class ConveyorOutput
    {
        public bool MotorOn { get; set; }
        public bool WarningLightOn { get; set; }
    }

    class ConveyorController
    {
        public ConveyorOutput Process(ConveyorInput input)
        {
            var output = new ConveyorOutput();

            if (input.EmergencyStop || input.SensorOverload)
            {
                output.MotorOn = false;
                output.WarningLightOn = true;
            }
            else if (input.SensorEntry)
            {
                output.MotorOn = true;
                output.WarningLightOn = false;
            }
            else
            {
                output.MotorOn = false;
                output.WarningLightOn = false;
            }

            return output;
        }
    }
}
