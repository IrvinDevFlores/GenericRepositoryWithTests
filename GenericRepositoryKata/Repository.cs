using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryKata
{
    public class Repository<T>: IRepository<T>  where T : class
    {
        List<T> items = new List<T>();
        public void Add(T entity)
        {
            items.Add(entity);
        }

        public T FindById(int id)
        {
            Type typeObject = typeof(T);
            T found = null;
            
            foreach(var item in items)
            {
                int idItem = Convert.ToInt32(typeObject.GetProperty("Id").GetValue(item, null));

               if (idItem == id) {
                   found = item;
                }else{
                    found = null;
                }
            }


            return found;
        }

        public IEnumerable<T> GetAll()
        {
            return items.AsEnumerable();
        }

        public void RemovedById(int id)
        {
            items.Remove(FindById(id));

            /*  foreach (var property in props)
              {
                  if (property.Name.ToUpper() == "ID")
                  {
                  S
                  }
              }*/
        }


    }
}
