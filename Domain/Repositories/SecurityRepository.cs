using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SecurityRepository
    {
        string dbConnection;
        private List<IUser> storeInMemory = null;

        public SecurityRepository(string dbConnection)
        {
            this.dbConnection = dbConnection;
        }
        public IUser[] GetAll()
        {
            return storeInMemory.ToArray();
        }

        public int Create(IUser fault)
        {
            if (storeInMemory.Exists(f => fault.UserName.Equals(f.UserName)))
                return -1;
            storeInMemory.Add(fault);
            return storeInMemory.Count();
        }

        public IUser RetrieveByUsername(string userName)
        {
            return storeInMemory.FirstOrDefault(f => f.UserName.Equals(userName));
        }

        public IUser RetrieveById(int id)
        {
            return storeInMemory.FirstOrDefault(f => f.Id.Equals(id));
        }

        public bool UpdateFault(IUser user)
        {
            return true;
        }

        public bool Delete(int userId)
        {
            for (int c = 0; c < storeInMemory.Count(); c++)
                if (storeInMemory[c].Id.Equals(userId))
                {
                    storeInMemory.Remove(storeInMemory[c]);
                    break;
                }

            return true;
        }

    }
}
