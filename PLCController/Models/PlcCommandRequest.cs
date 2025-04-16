using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLCController.Models
{
    public class PlcCommandRequest
    {
        public string MotorOn { get; set; } // π.χ. "MotorOn"
        public bool State { get; set; }        // true = ON, false = OFF
    }

}
