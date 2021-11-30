using System;
using System.IO;

namespace NET.DesignPatterns.Tools
{
    public sealed class Log
    {
        private static Log instance = null;
        private string path;
        private static object protect = new object();

        public static Log GetInstance(string path)
        {
            lock(protect)
            {
                if (instance == null)
                    instance = new Log(path);
            }

            return instance;

        }

        private Log(string path) { this.path = path; }

        public void Save(string message)
        {
            File.AppendAllText(path, message + Environment.NewLine);
        }

    }
}
