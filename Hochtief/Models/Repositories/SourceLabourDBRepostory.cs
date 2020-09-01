using Hochtief.Models;
using Hochtief.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigApp.Models.Repositories
{
    public class SourceLabourDBRepostory :IRepostory<SourceLabour>
    {
        TestDBContext db;
        public SourceLabourDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(SourceLabour entity)
        {
            db.sourceLabours.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.sourceLabours.Remove(ob);
            db.SaveChanges();
        }
        public SourceLabour Find(int id)
        {
            var ob = db.sourceLabours.SingleOrDefault(x => x.personalID == id);
            return ob;
        }
        public IList<SourceLabour> List()
        {
            return db.sourceLabours.ToList();
        }
        public void Update(int id, SourceLabour newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}

