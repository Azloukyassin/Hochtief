using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class pdsDBRepostory : IRepostory<Pds>
    {
        TestDBContext db;
        public pdsDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(Pds entity)
        {
            db.pds.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.pds.Remove(ob);
            db.SaveChanges();
        }
        public Pds Find(int id)
        {
            var ob = db.pds.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<Pds> List()
        {
            return db.pds.ToList();
        }
        public void Update(int id, Pds newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
