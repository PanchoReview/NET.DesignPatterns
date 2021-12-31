using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DesignPatterns.Tools.Earn
{
    public class ForeignEarnFactory : EarnFactory
    {
        private decimal percentage;
        private decimal extra;

        public ForeignEarnFactory(decimal percentage, decimal extra)
        {
            this.percentage = percentage;
            this.extra = extra;
        }

        public override IEarn GetEarn()
        {
            return new ForeignEarn(percentage, extra);
        }
    }
}
