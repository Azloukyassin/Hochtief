using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class MainActivityDBRepostroy :IRepostory<MainActivity>
    {
        TestDBContext db;
        public MainActivityDBRepostroy(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(MainActivity entity)
        {
            db.MainActivities.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.MainActivities.Remove(ob);
            db.SaveChanges();
        }
        public MainActivity Find(int id)
        {
            var ob = db.MainActivities.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<MainActivity> List()
        {
            return db.MainActivities.ToList();
        }
        public void Update(int id, MainActivity newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
