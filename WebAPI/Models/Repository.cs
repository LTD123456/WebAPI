using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DBContext;

namespace WebAPI.Models
{
    public class Repository<Context> : IRepository where Context : StudentContext
    {
        private Context context;

        public Repository(Context cntext)
        {
            this.context = cntext;
        }

        public void CreateAsync<T>(T entity) where T : class
        {
            this.context.Set<T>().Add(entity);
        }

        public void DeleteAsync<T>(int id) where T : class
        {
            var entity = this.context.Set<T>().Find(id);
            if(entity!=null)
            {
                this.context.Set<T>().Remove(entity);
            }
        }

        public List<T> FindAll<T>() where T : class
        {
            return this.context.Set<T>().ToList();
        }

        public T FindById<T>(int id) where T : class
        {
            return this.context.Set<T>().Find(id);
        }

        public void UpdateAsync<T>(T entity) where T : class
        {
            this.context.Set<T>().Update(entity);
        }
    }
}
