using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApp.Models.Repostories
{
    public class SourceCompanyA6 :IRepostory<A6SourceCompanytest>
    {
        MohamedAzloukSandboxEntitiesA6 db;
        public SourceCompanyA6(MohamedAzloukSandboxEntitiesA6 _db) :base()
        {
            this.db = _db;
        }
        public void Add(A6SourceCompanytest entity)
        {
            db.A6SourceCompanytest.Add(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ob = Find(id);
            db.A6SourceCompanytest.Remove(ob);
            db.SaveChanges();
        }
        public A6SourceCompanytest Find(int id)
        {
            var ob = db.A6SourceCompanytest.SingleOrDefault(x => x.sourceCompany_id == id);
            return ob;
        }
        public IList<A6SourceCompanytest> List()
        {
            return db.A6SourceCompanytest.ToList();
        }
        
    }
}