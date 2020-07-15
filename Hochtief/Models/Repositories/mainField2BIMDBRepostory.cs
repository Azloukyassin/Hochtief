using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class mainField2BIMDBRepostory :IRepostory<MainField2BIM>
    {
        TestDBContext db;
        public mainField2BIMDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(MainField2BIM entity)
        {
            db.mainField2BIMs.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.mainField2BIMs.Remove(ob);
            db.SaveChanges();
        }
        public MainField2BIM Find(int id)
        {
            var ob = db.mainField2BIMs.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<MainField2BIM> List()
        {
            return db.mainField2BIMs.ToList();
        }
        public void Update(int id, MainField2BIM newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }

       
    }
}
