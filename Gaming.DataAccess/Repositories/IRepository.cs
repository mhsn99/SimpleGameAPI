using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming.Entities;

namespace Gaming.DataAccess.Repositories
{
    public interface IRepository<T> where T : IEntity, new()
    {
        Task <IList<T>> GetAll();
        Task<T> GetById(int id);
    }
}
