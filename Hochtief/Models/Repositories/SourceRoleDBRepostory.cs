using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class SourceRoleDBRepostory:IRepostory<SourceRole>
    {
        TestDBContext db;
        public SourceRoleDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(SourceRole entity)
        {
            db.Source_Roles.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.Source_Roles.Remove(ob);
            db.SaveChanges();
        }
        public SourceRole Find(int id)
        {
            var ob = db.Source_Roles.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<SourceRole> List()
        {
            return db.Source_Roles.ToList();
        }
        public void Update(int id, SourceRole newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}

