using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class SourceEquipmentDBRepostory :IRepostory<SourceEquipment>
    {
        TestDBContext db;
        public SourceEquipmentDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(SourceEquipment entity)
        {
            db.sourceEquipment.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.sourceEquipment.Remove(ob);
            db.SaveChanges();
        }
        public SourceEquipment Find(int id)
        {
            var ob = db.sourceEquipment.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<SourceEquipment> List()
        {
            return db.sourceEquipment.ToList();
        }
        public void Update(int id, SourceEquipment newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
