using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DesignPatterns.Tools.Earn
{
    public class LocalEarnFactory : EarnFactory
    {
        private decimal percentage;

        public LocalEarnFactory(decimal percentage)
        {
            this.percentage = percentage;
        }

        public override IEarn GetEarn()
        {
            return new LocalEarn(percentage);
        }
    }
}
