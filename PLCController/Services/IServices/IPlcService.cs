using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLCController.Services.IServices
{
    public interface IPlcService
    {
        Dictionary<string, bool> ReadInputsAndOutputs();
        bool WriteOutput(string name, bool state);
    }
}
