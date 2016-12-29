using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    public class Person
    {
        private int age;
        private Gender gender;
        private string name;
        private PersonType type;
        private PartyType party;

        public Person(string name, int age, Gender gender, PersonType type, PartyType politicalParty)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.type = type;
            this.party = politicalParty;
        }

        public string getName()
        {
            return this.name; 
        }

        public int getAge()
        {
           return this.age; 
        }

        public Gender getGender()
        {
             return this.gender; 

        }

        public PersonType getType()
        {
             return this.type; 
        }

        public PartyType getPoliticalParty()
        {
             return this.party;
        }

        public void setName(string name)
        {
             this.name = name;
        }

        public void setAge(int age)
        {
             this.age = age;
        }

        public void setGender(Gender gender)
        {
             this.gender = gender;

        }

        public void setType(PersonType personType)
        {
             this.type = personType;
        }

        public void setPoliticalParty(PartyType partyType)
        {
            this.party = partyType;
        }

        public string ToString()
        {
            return " Person:" +
                " Name [" + this.name +
                "], Age [" + this.age +
                "], Gender [" + this.gender +
                "], Type [" + this.type +
                "], PoliticalParty [" + this.party +
                "]";
        }

    }

    public enum Gender { MALE, FEMALE}

    public enum PersonType
    {
        Lawyer,
        Architect,
        Politician,
        President
    }

    public enum PartyType
    {
        ANC,
        DA,
        EFF,
        Other
    }
}
