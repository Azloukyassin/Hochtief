using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class LabourInternalDBRepostory : IRepostory<LabourInternal>
    {
        TestDBContext db;
        public LabourInternalDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(LabourInternal entity)
        {
            db.LabourInt.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.LabourInt.Remove(ob);
            db.SaveChanges();
        }
        public LabourInternal Find(int id)
        {
            var ob = db.LabourInt.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<LabourInternal> List()
        {
            return db.LabourInt.ToList();
        }
        public void Update(int id, LabourInternal newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
