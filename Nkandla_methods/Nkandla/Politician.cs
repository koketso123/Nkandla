using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    public class Politician : Person, Visitor
    {

        public Politician(string name, int age, Gender gender, PersonType type, PartyType politicalParty) : base(name, age, gender, type, politicalParty)
        {
            
        }

        public void visit(HomeStead homeStead)
        {
            if (base.getType().Equals(PersonType.Politician) && !base.getPoliticalParty().Equals(PartyType.ANC))
                Console.WriteLine(base.getName() + ": Pay back the money!!!");
            else
                Console.WriteLine(base.getName() + ", welcome to Nkandla!");
        }

        public string ToString()
        {
            return "Politician" + base.ToString();
        }
    }
}
