/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
        public class LabourDBRepostory : IRepostory<Labour>
        {
            TestDBContext db;
            public LabourDBRepostory(TestDBContext _db)
            {
                this.db = _db;
            }
            public void Add(Labour entity)
            {
                db.labours.Add(entity);
                db.SaveChanges();
            }
            public void Delete(int id)
            {
                var ob = Find(id);
                db.labours.Remove(ob);
                db.SaveChanges();
            }
            public Labour Find(int id)
            {
                var ob = db.labours.SingleOrDefault(x => x.id == id);
                return ob;
            }
            public IList<Labour> List()
            {
                return db.labours.ToList();
            }
            public void Update(int id, Labour newtabelle)
            {
                db.Update(newtabelle);
                db.SaveChanges();
            }
        }
}
*/

