using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class mainEquipmentDBRepostory :IRepostory<MainEquipment>
    {
        TestDBContext db;
        public mainEquipmentDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(MainEquipment entity)
        {
            db.MainEquipment.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.MainEquipment.Remove(ob);
            db.SaveChanges();
        }
        public MainEquipment Find(int id)
        {
            var ob = db.MainEquipment.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<MainEquipment> List()
        {
            return db.MainEquipment.ToList();
        }
        public void Update(int id, MainEquipment newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
