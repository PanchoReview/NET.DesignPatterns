using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DesignPatterns.Tools.Earn
{
    public class LocalEarn : IEarn
    {
        private decimal percentage;

        public LocalEarn(decimal percentage)
        {
            this.percentage = percentage;
        }

        public decimal Earn(decimal amount)
        {
            return amount * percentage;
        }
    }
}
