/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class SourceStaffDBRepostory : IRepostory<SourceStaff>
    {
        TestDBContext db;
        public SourceStaffDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(SourceStaff entity)
        {
            db.sourceStaffs.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.sourceStaffs.Remove(ob);
            db.SaveChanges();
        }
        public SourceStaff Find(int id)
        {
            var ob = db.sourceStaffs.SingleOrDefault(x => x.peronalID == id);
            return ob;
        }
        public IList<SourceStaff> List()
        {
            return db.sourceStaffs.ToList();
        }
        public void Update(int id, SourceStaff newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
*/