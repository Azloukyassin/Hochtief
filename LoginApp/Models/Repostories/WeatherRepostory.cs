using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApp.Models.Repostories
{
    public class WeatherRepostory : IRepostory<Weathertest>
    {
        MohamedAzloukSandboxEntities4 Model;
        // Loot it later . is not Done ! 
        public IEnumerable<Weathertest> weather { get; set; }
        public WeatherRepostory(MohamedAzloukSandboxEntities4 model , IEnumerable<Weathertest> Weather)
        {
            this.Model = model;
            this.weather = Weather;
        }
        public IList<Weathertest> List()
        {
            return Model.Weathertest.ToList(); 
        }   
    }
}
