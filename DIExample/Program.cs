using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogWriter logWriter = new ConsoleLogWriter();
            var logger = new Log(logWriter);
        }
    }

    internal class Log
    {
        private readonly ILogWriter _logWriter;

        public Log(ILogWriter logWriter)
        {
            _logWriter = logWriter;
        }

        public void DoSomething()
        {
            _logWriter.Write("test");
        }
    }
}
