using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DesignPatterns.Tools.Earn
{
    public class ForeignEarn : IEarn
    {
        private decimal percentage;
        private decimal extra;

        public ForeignEarn(decimal percentage, decimal extra)
        {
            this.percentage = percentage;
            this.extra = extra;
        }

        public decimal Earn(decimal amount)
        {
            return (amount * percentage) + extra;
        }
    }
}
