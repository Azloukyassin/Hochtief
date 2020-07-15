using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class TestDBRepostory:IRepostory<TestTabelle>
    {
        TestDBContext db; 
        public TestDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(TestTabelle entity)
        {
            db.testTabelle.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.testTabelle.Remove(ob);
            db.SaveChanges();
        }
        public TestTabelle Find(int id)
        {
            var ob = db.testTabelle.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<TestTabelle> List()
        {
            return db.testTabelle.ToList();
        }
        public void Update(int id, TestTabelle newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}

