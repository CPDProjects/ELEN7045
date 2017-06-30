using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    public class ReportCardRepository
    {
        private string dbConnection;

        //in-memory fault store
        private List<ReportCard> storeInMemory = null;

        public ReportCardRepository(string dbConnection)
        {
            storeInMemory = new List<ReportCard>();
        }

        public ReportCard[] GetAll()
        {
            return storeInMemory.ToArray();
        }

        public virtual int Create(ReportCard entity)
        {
            storeInMemory.Add(entity);
            return storeInMemory.Count();
        }

        public IReportCard RetrieveById(int id)
        {
            return storeInMemory.FirstOrDefault(f => f.Id.Equals(id));
        }

        public IReportCard RetrieveByReferenceNo(string reference)
        {
            return storeInMemory.FirstOrDefault(f => f.ReferenceNo.Equals(reference));
        }

        public virtual bool Update(ReportCard entity)
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
