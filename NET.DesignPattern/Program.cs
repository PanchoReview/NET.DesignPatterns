using NET.DesignPattern.FactoryPattern;
using System;

namespace NET.DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            SaleFactory internetSaleFactory = new InternetSaleFactory(3);

            ISale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(15);

            ISale sale2 = internetSaleFactory.GetSale();
            sale2.Sell(15);
        }
    }
}
