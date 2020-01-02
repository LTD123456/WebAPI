using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DBContext;

namespace WebAPI.Models
{
    public interface IUnitOfWork : IDisposable
    {
        StudentContext Context { get; }
        void Commit();
    }
}
