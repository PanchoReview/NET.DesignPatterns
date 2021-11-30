using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DesignPattern.Singleton
{
    public class Log
    {
        private static readonly Log instance = new Log();
        private string path = "log.txt";

        public static Log Instance { get { return instance;} }

        private Log() { }

        public void Save(string message)
        {
            File.AppendAllText(path, message + Environment.NewLine);
        }

    }
}
