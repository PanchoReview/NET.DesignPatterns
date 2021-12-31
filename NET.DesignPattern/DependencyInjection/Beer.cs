using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DesignPattern.DependencyInjection
{
    public class Beer
    {
        private string name;
        private string brand;

        public string Name { get { return name; } }
        public Beer(string name, string brand)
        {
            this.name = name;
            this.brand = brand;
        }
    }
}
