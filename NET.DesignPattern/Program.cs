using NET.DesignPattern.FactoryPattern;
using NET.DesignPattern.RepositoryPattern;
using NET.DesignPatterns.Model;
using System;

namespace NET.DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DesignPatternsContext())
            {
                var beerRepository = new BeerRepository(context);
                var beer = new Beer();
                beer.Name = "Corona";
                beer.Style = "Pilsner";
                beerRepository.Add(beer);
                beerRepository.Save();

                var list = beerRepository.Get();
                foreach (var b in list)
                {
                    Console.WriteLine(b.Name);
                }
            }
        }
    }
}
