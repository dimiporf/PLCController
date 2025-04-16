using PLCController.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLCController.Services
{
    public class MockPlcService : IPlcService
    {
        private Dictionary<string, bool> ioState = new()
    {
        { "SensorEntry", false },
        { "SensorOverload", false },
        { "EmergencyStop", false },
        { "MotorOn", false },
        { "WarningLightOn", false },
    };

        public Dictionary<string, bool> ReadInputsAndOutputs()
        {
            return ioState;
        }

        public bool WriteOutput(string name, bool state)
        {
            if (!ioState.ContainsKey(name))
                return false;

            ioState[name] = state;
            return true;
        }
    }
}
