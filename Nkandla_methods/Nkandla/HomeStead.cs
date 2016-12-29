using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    public class HomeStead
    {
        private string name;
        private string district;
        private string province;
        private string country;

        public HomeStead(string name, string district, string province, string country)
        {
            this.name = name;
            this.district = district;
            this.province = province;
            this.country = country;
        }

        public string getName()
        {
            return this.name;
        }

        public string getDistrict()
        {
             return this.district; 
        }

        public string getProvince()
        {
             return this.province; 
        }

        public string getCountry()
        {
            return this.country; 
        }

        public void setName( string name)
        {
            this.name = name;
        }

        public void getDistrict(string district)
        {
             this.district = district;
        }

        public void getProvince(string province)
        {
            this.province = province;
        }

        public void getCountry(string country)
        {
            this.country = country;
        }

        public void accept(Visitor visitor)
        {
            if (visitor != null)
                visitor.visit(this);
        }

        public string ToString()
        {
            return "HomeStead:" +
                " Name [" + this.name +
                "] District [" + this.district +
                "] Province [" + this.province +
                "] Country [" + this.country +
                "]";
        }
    }
}
