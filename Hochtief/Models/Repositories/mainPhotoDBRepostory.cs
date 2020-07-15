using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class mainPhotoDBRepostory : IRepostory<MainPhotos>
    {
        TestDBContext db;
        public mainPhotoDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(MainPhotos entity)
        {
            db.mainPhotos.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.mainPhotos.Remove(ob);
            db.SaveChanges();
        }
        public MainPhotos Find(int id)
        {
            var ob = db.mainPhotos.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<MainPhotos> List()
        {
            return db.mainPhotos.ToList();
        }
        public void Update(int id, MainPhotos newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}
