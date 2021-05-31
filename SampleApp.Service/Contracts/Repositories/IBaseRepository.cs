using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Service.Contracts.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(int id);

        T GetById(int id);

        IReadOnlyList<T> ListAll();
    }
}
