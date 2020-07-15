using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class WeatherDBRepostory :IRepostory<Weather>
    {
        TestDBContext db;
        public WeatherDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(Weather entity)
        {
            db.Weather.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.Weather.Remove(ob);
            db.SaveChanges();
        }
        public Weather Find(int id)
        {
            var ob = db.Weather.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<Weather> List()
        {
            return db.Weather.ToList();
        }
        public void Update(int id, Weather newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}

