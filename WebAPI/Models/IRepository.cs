using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public interface IRepository
    {
        List<T> FindAll<T>() where T : class;
        T FindById<T>(int id) where T : class;
        void CreateAsync<T>(T entity) where T : class;
        void UpdateAsync<T>(T entity) where T : class;
        void DeleteAsync<T>(int id) where T : class;
    }
}
