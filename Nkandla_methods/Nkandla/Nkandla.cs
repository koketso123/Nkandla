using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla 
{
    class Nkandla : HomeStead
    {

        private ChickenRun chickenRun;
        private SwimmingPool swimmingPool;
        private Amphitheatre amphitheatre;

        public Nkandla(string name, string district, string province, string country) : base(name, district, province, country)
        {
            
        }

        public ChickenRun getChickenRun()
        {
             return this.chickenRun; 
        }

        public SwimmingPool getSwimmingPool()
        {
            return this.swimmingPool;
        }

        public Amphitheatre getAmphitheatre()
        {
            return this.amphitheatre;
        }

        public void setAmphitheatre(Amphitheatre amphitheatre)
        {
             this.amphitheatre = amphitheatre; 
        }

        public void setChickenRun(ChickenRun chickenRun)
        {
            this.chickenRun = chickenRun;
        }

        public void setSwimmingPool(SwimmingPool swimmingPool)
        {
            this.swimmingPool = swimmingPool;
        }

    }
}
