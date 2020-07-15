using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class mainSignatureDBRepostory : IRepostory<MainSignaturePhotos>
    {
        TestDBContext db;
        public mainSignatureDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(MainSignaturePhotos entity)
        {
            db.mainSignaturePhotos.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.mainSignaturePhotos.Remove(ob);
            db.SaveChanges();
        }
        public MainSignaturePhotos Find(int id)
        {
            var ob = db.mainSignaturePhotos.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<MainSignaturePhotos> List()
        {
            return db.mainSignaturePhotos.ToList();
        }
        public void Update(int id, MainSignaturePhotos newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
