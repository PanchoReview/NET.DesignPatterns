using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DesignPattern.FactoryPattern
{
    //Creator
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }

    //Concrete Creator
    public class StoreSaleFactory : SaleFactory
    {
        private decimal extra;

        public StoreSaleFactory(decimal extra)
        {
            this.extra = extra;
        }

        public override ISale GetSale()
        {
            return new StoreSale(extra);
        }
    }

    public class InternetSaleFactory : SaleFactory
    {
        private decimal discount;

        public InternetSaleFactory(decimal discount)
        {
            this.discount = discount;
        }

        public override ISale GetSale()
        {
            return new InternetSale(discount);
        }
    }

    //Concrete Product
    public class StoreSale : ISale
    {
        private decimal extra;

        public StoreSale(decimal extra)
        {
            this.extra = extra;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en tienda tiene un total de {total + extra}");
        }
    }

    public class InternetSale : ISale
    {
        private decimal discount;

        public InternetSale(decimal discount)
        {
            this.discount = discount;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en internet tiene un total de {total - discount}");
        }
    }



    //Product
    public interface ISale
    {
        public void Sell(decimal total);
    }
}
