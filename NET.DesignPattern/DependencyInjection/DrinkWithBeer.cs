using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DesignPattern.DependencyInjection
{
    public class DrinkWithBeer
    {
        private Beer beer;
        private decimal water;
        private decimal sugar;

        public DrinkWithBeer(decimal water, decimal sugar, Beer beer)
        {
            this.water = water;
            this.sugar = sugar;
            this.beer = beer;
        }

        public void Build()
        {
            Console.WriteLine($"Preparamos bebida que tiene agua {water}, azúcar {sugar} y cerveza {beer.Name}");
        }
    }
}
