using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class mainActivitySubTasksDBRepostory :IRepostory<MainActivitySubTasks>
    {
        TestDBContext db;
        public mainActivitySubTasksDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(MainActivitySubTasks entity)
        {
            db.mainActivitySubTasks.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.mainActivitySubTasks.Remove(ob);
            db.SaveChanges();
        }
        public MainActivitySubTasks Find(int id)
        {
            var ob = db.mainActivitySubTasks.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<MainActivitySubTasks> List()
        {
            return db.mainActivitySubTasks.ToList();
        }
        public void Update(int id, MainActivitySubTasks newtabelle)
        { 
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
