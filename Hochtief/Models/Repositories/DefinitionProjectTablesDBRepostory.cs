using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class DefinitionProjectTablesDBRepostory : IRepostory<DefinitionProjectTables>
    {
        TestDBContext db;
        public DefinitionProjectTablesDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(DefinitionProjectTables entity)
        {
            db.dtables.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.dtables.Remove(ob);
            db.SaveChanges();
        }
        public DefinitionProjectTables Find(int id)
        {
            var ob = db.dtables.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<DefinitionProjectTables> List()
        {
            return db.dtables.ToList();
        }
        public void Update(int id, DefinitionProjectTables newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
