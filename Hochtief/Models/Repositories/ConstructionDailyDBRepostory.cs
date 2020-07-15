using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class ConstructionDailyDBRepostory : IRepostory<ConstructionDailyPhoto>
    {
        TestDBContext db;
        public ConstructionDailyDBRepostory(ConstructionDailyPhoto _db)
        {
            this.db = _db;
        }
        public void Add(ConstructionDailyPhoto entity)
        {
            db.constructionDailyPhotos.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.constructionDailyPhotos.Remove(ob);
            db.SaveChanges();
        }
        public ConstructionDailyPhoto Find(int id)
        {
            var ob = db.constructionDailyPhotos.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<ConstructionDailyPhoto> List()
        {
            return db.constructionDailyPhotos.ToList();
        }
        public void Update(int id, ConstructionDailyPhoto newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
