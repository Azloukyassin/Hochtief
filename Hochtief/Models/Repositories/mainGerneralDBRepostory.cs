using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class mainGerneralDBRepostory :IRepostory<MainGeneral>
    {
        TestDBContext db;
        public mainGerneralDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(MainGeneral entity)
        {
            db.mainGenerals.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.mainGenerals.Remove(ob);
            db.SaveChanges();
        }
        public MainGeneral Find(int id)
        {
            var ob = db.mainGenerals.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<MainGeneral> List()
        {
            return db.mainGenerals.ToList();
        }
        public void Update(int id, MainGeneral newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
