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
                var beerRepository = new Repository<Beer>(context);
                var beer = new Beer() { Name = "Pancho Beer", Style = "Awesome Beer" };
                beerRepository.Add(beer);
                beerRepository.Save();

                foreach(var b in beerRepository.Get())
                {
                    Console.WriteLine(b.Name);
                }
            }
        }
    }
}
