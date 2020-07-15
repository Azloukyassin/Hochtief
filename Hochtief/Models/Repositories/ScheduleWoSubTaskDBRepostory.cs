using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class ScheduleWoSubTaskDBRepostory : IRepostory<ScheduleWoSubTask>
    {
        TestDBContext db;
        public ScheduleWoSubTaskDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(ScheduleWoSubTask entity)
        {
            db.scheduleWoSubs.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.scheduleWoSubs.Remove(ob);
            db.SaveChanges();
        }
        public ScheduleWoSubTask Find(int id)
        {
            var ob = db.scheduleWoSubs.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<ScheduleWoSubTask> List()
        {
            return db.scheduleWoSubs.ToList();
        }
        public void Update(int id, ScheduleWoSubTask newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
