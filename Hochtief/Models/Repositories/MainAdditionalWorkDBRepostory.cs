using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class MainAdditionalWorkDBRepostory : IRepostory<MainAdditionalWorks>
    {
        TestDBContext db;
        public MainAdditionalWorkDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(MainAdditionalWorks entity)
        {
            db.mainAdditionalWorks.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.mainAdditionalWorks.Remove(ob);
            db.SaveChanges();
        }
        public MainAdditionalWorks Find(int id)
        {
            var ob = db.mainAdditionalWorks.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<MainAdditionalWorks> List()
        {
            return db.mainAdditionalWorks.ToList();
        }
        public void Update(int id, MainAdditionalWorks newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
