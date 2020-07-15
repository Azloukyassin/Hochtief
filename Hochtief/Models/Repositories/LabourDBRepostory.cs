using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class LabourDBRepostory 
    {
    }
}
       /* TestDBContext db; 
        public LabourDBRepostory(TestDBContext _db)
        {
            this.db = _db; 
        }
        public void Add(Labour labour)
        {
            db.Labour.Add(labour);
            db.SaveChanges(); 
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.Labour.Remove(ob);
            db.SaveChanges(); 
        }
        public Labour Find(int id)
        {
            var ob = db.Labour.SingleOrDefault(x => x.pid == id);
            return ob; 
        }
        public IList<Labour> List()
        {
            return db.Labour.ToList(); 
        }
        public void Update(int id , Labour newmodell)
        {
            db.Update(newmodell);
            db.SaveChanges(); 
        }
    }
}
*/