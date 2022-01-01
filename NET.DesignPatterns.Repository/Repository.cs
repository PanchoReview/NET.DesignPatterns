using Microsoft.EntityFrameworkCore;
using NET.DesignPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DesignPatterns.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DesignPatternsContext context;
        private DbSet<TEntity> dbSet;

        public Repository(DesignPatternsContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }


        public void Add(TEntity data) => dbSet.Add(data);

        public void Delete(int id)
        {
            var data = dbSet.Find(id);
            dbSet.Remove(data);
        }

        public IEnumerable<TEntity> Get() => dbSet.ToList();

        public TEntity Get(int id) => dbSet.Find(id);

        public void Save() => context.SaveChanges();

        public void Update(TEntity data)
        {
            dbSet.Attach(data);
            context.Entry(data).State = EntityState.Modified;
        }
    }
}
