using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLCController.Models
{
    public class PlcCommandRequest
    {
        public string OutputName { get; set; } 
        public bool State { get; set; }        
    }

}
