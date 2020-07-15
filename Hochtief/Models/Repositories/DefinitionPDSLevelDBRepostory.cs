
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class DefinitionPDSLevelDBRepostory : IRepostory<DefinitionPDSLevel>
    {
        TestDBContext db;
        public DefinitionPDSLevelDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(DefinitionPDSLevel entity)
        {
            db.definitionPDSLevels.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.definitionPDSLevels.Remove(ob);
            db.SaveChanges();
        }
        public DefinitionPDSLevel Find(int id)
        {
            var ob = db.definitionPDSLevels.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<DefinitionPDSLevel> List()
        {
            return db.definitionPDSLevels.ToList();
        }
        public void Update(int id, DefinitionPDSLevel newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
