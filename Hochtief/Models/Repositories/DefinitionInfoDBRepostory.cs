using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class DefinitionInfoDBRepostory :IRepostory<DefinitionInfo>
    {
        TestDBContext db;
        public DefinitionInfoDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(DefinitionInfo entity)
        {
            db.definitionInfos.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.definitionInfos.Remove(ob);
            db.SaveChanges();
        }
        public DefinitionInfo Find(int id)
        {
            var ob = db.definitionInfos.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<DefinitionInfo> List()
        {
            return db.definitionInfos.ToList();
        }
        public void Update(int id, DefinitionInfo newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
