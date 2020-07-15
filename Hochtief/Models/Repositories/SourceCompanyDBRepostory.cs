using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public class SourceCompanyDBRepostory :IRepostory<SourceCompany>
    {
        TestDBContext db;
        public SourceCompanyDBRepostory(TestDBContext _db)
        {
            this.db = _db;
        }
        public void Add(SourceCompany entity)
        {
            db.sourceCompanies.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.sourceCompanies.Remove(ob);
            db.SaveChanges();
        }
        public SourceCompany Find(int id)
        {
            var ob = db.sourceCompanies.SingleOrDefault(x => x.id == id);
            return ob;
        }
        public IList<SourceCompany> List()
        {
            return db.sourceCompanies.ToList();
        }
        public void Update(int id, SourceCompany newtabelle)
        {
            db.Update(newtabelle);
            db.SaveChanges();
        }
    }
}

