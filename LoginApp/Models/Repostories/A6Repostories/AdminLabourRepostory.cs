using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApp.Models.Repostories
{
    public class AdminLabourRepostory :IRepostory<A6Labourtest>
    {
        MohamedAzloukSandboxEntitiesA6 _db;
        public AdminLabourRepostory(MohamedAzloukSandboxEntitiesA6 db)
        {
            this._db = db;
        }
        public void Add(A6Labourtest entity)
        {
            _db.A6Labourtest.Add(entity);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            _db.A6Labourtest.Remove(ob);
            _db.SaveChanges();
        }
        public A6Labourtest Find(int id)
        {
            var ob = _db.A6Labourtest.SingleOrDefault(x => x.labour_id== id);
            return ob;
        }
        public IList<A6Labourtest> List()
        {
            return _db.A6Labourtest.ToList();
        }
        public void Update(int id, A6Labourtest newtabelle)
        {
            _db.(newtabelle);
            _db.SaveChanges();
        }

       

    }
}
