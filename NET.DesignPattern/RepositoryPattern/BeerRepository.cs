using Microsoft.EntityFrameworkCore;
using NET.DesignPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DesignPattern.RepositoryPattern
{
    public class BeerRepository : IBeerRepository
    {
        private DesignPatternsContext context;

        public BeerRepository(DesignPatternsContext context)
        {
            this.context = context;
        }

        public void Add(Beer data) => context.Beers.Add(data);
        

        public void Delete(int id)
        {
            var beer = context.Beers.Find(id);
            context.Beers.Remove(beer);
        }

        public IEnumerable<Beer> Get() => context.Beers.ToList();        

        public Beer Get(int id) => context.Beers.Find(id);        

        public void Save() => context.SaveChanges();

        public void Update(Beer data) => context.Entry(data).State = EntityState.Modified;
        
    }
}
