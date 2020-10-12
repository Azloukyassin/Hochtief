using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApp.Models.Repostories
{
    public class WeatherRepostory : IRepostory<Weathertest>
    {
        public IList<Weathertest> List()
        {
            MohamedAzloukSandboxEntities4 model = new MohamedAzloukSandboxEntities4();
            return model.Weathertest.ToList(); 
        }
    }
}