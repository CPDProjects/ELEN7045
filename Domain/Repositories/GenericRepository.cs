using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GenericRepository<T> where T: IModel
    {
        private string dbConnection;
     
            //in-memory fault store
            private List<T> storeInMemory = null;

            public GenericRepository(string dbConnection)
            {
                storeInMemory = new List<T>();
            }

            public T[] GetAll()
            {            
                return storeInMemory.ToArray();
            }

            public virtual int Create(T entity)
            {
                storeInMemory.Add(entity);
                return storeInMemory.Count();
            }

            public IModel RetrieveById(int id)
            {
                return storeInMemory.FirstOrDefault(f => f.Id.Equals(id));
            }

            public IModel RetrieveByReferenceNo(string referenceNo)
            {
                return storeInMemory.FirstOrDefault(f => f.ReferenceNo.Equals(referenceNo));
            }

            public virtual bool Update(T entity)
            {
                for (int c = 0; c < storeInMemory.Count(); c++)
                if (storeInMemory[c].Id.Equals(entity.Id))
                {
                    storeInMemory[c] = entity;
                    break;
                }

            return true;
            }

            public bool Delete(int id)
            {
                for (int c = 0; c < storeInMemory.Count(); c++)
                    if (storeInMemory[c].Id.Equals(id))
                    {
                        storeInMemory.Remove(storeInMemory[c]);
                        break;
                    }

                return true;
            }


    }
}
