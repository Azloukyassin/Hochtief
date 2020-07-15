using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class ScheduleDBRepostory :IRepostory<Schedule>
    {
        TestDBContext db;
        public ScheduleDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(Schedule entity)
        {
            db.schedules.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.schedules.Remove(ob);
            db.SaveChanges();
        }
        public Schedule Find(int id)
        {
            var ob = db.schedules.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<Schedule> List()
        {
            return db.schedules.ToList();
        }
        public void Update(int id, Schedule newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
