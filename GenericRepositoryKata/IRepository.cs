using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryKata
{
    public interface IRepository<T>
    {
        void Add(T obj);
        T FindById(int id);

        void RemovedById(int id);

        IEnumerable<T> GetAll();
    }
}
