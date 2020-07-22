using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; //entityframework
using Projeto.Entities; //importando
using Projeto.DAL.Context; //importando
using Projeto.DAL.Contracts; //importando

namespace Projeto.DAL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        public virtual void Insert(T obj)
        {
            using (var ctx = new DataContext())
            {
                ctx.Entry(obj).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public virtual void Update(T obj)
        {
            using (var ctx = new DataContext())
            {
                ctx.Entry(obj).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public virtual void Remove(T obj)
        {
            using (var ctx = new DataContext())
            {
                ctx.Entry(obj).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }

        public virtual List<T> FindAll()
        {
            using (var ctx = new DataContext())
            {
                return ctx.Set<T>().ToList();
            }
        }

        public virtual T FindById(int id)
        {
            using (var ctx = new DataContext())
            {
                return ctx.Set<T>().Find(id);
            }
        }
    }
}
