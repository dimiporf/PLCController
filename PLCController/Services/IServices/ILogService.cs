using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLCController.Services.IServices
{
    public interface ILogService
    {
        void Log(string message);
        IEnumerable<string> GetAllLogs();
    }

}
