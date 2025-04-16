using PLCController.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLCController.Services
{
    public class LogService : ILogService
    {
        private readonly List<string> _logEntries = new();

        public void Log(string message)
        {
            string entry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            _logEntries.Add(entry);
        }

        public IEnumerable<string> GetAllLogs() => _logEntries.ToArray();
    }

}
