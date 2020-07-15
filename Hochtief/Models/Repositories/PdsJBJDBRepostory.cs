using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class PdsJBJDBRepostory : IRepostory<pdsJBJ>
    {
        TestDBContext db;
        public PdsJBJDBRepostory(TestDBContext _db)
        { 
            this.db = _db;
        }
        public void Add(pdsJBJ entity)
        {
            db.pdsJBJs.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.pdsJBJs.Remove(ob);
            db.SaveChanges();
        }
        public pdsJBJ Find(int id)
        {
            var ob = db.pdsJBJs.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<pdsJBJ> List()
        {
            return db.pdsJBJs.ToList();
        }
        public void Update(int id, pdsJBJ newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
