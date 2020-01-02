using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DBContext;

namespace WebAPI.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        public StudentContext Context { get; }

        public UnitOfWork(StudentContext cntext)
        {
            this.Context = cntext;
        }

        public void Commit()
        {
            this.Context.SaveChanges();
        }

        public void Dispose()
        {
            this.Context.Dispose();
        }
    }
}
