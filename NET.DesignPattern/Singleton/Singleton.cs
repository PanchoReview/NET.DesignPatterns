using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DesignPattern.Singleton
{
    public class Singleton
    {
        private readonly static Singleton instance = new Singleton();

        public static Singleton Instance { get { return instance; } }
        private Singleton()
        {

        }
    }
}
