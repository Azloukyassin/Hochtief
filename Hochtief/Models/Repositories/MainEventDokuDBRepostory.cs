using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Hochtief.Models.Repositories
{
    public class MainEventDokuDBRepostory
    {
        TestDBContext db;
        public MainEventDokuDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(MainEventDoku entity)
        {
            db.mainEventDokus.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.mainEventDokus.Remove(ob);
            db.SaveChanges();
        }
        public MainEventDoku Find(int id)
        {
            var ob = db.mainEventDokus.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<MainEventDoku> List()
        {
            return db.mainEventDokus.ToList();
        }
        public void Update(int id, MainEventDoku newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
