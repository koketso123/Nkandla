using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeStead home = new HomeStead("Zuma", "Wierda", "Gauteng", "ZA");
            Nkandla nkandla = new Nkandla("Zuma", "Wierda", "Gauteng", "ZA");

            //Testing
            string temp = "HomeStead:" +" Name [Zuma] District [Wierda] Province [Gauteng] Country [ZA]";
            if (temp.Equals(home.ToString()))
                Console.WriteLine("HomeStead initiated correct");

            ChickenRun chickens = new ChickenRun();
            chickens.setNumberOfChickens(50);

            SwimmingPool firePool = new SwimmingPool();
            firePool.setHeight(100);
            firePool.setWidth(75);

            Amphitheatre amphi = new Amphitheatre();
            amphi.setNumberOfSeats(5000);

            nkandla.setChickenRun(chickens);
            nkandla.setSwimmingPool(firePool);
            nkandla.setAmphitheatre(amphi);

            //Testing the properties of Nkandla
            Console.WriteLine("Nkandla ChickenRun: NumberOfChickens = " + chickens.getNumberOfChickens());
            Console.WriteLine("Nkandla SwimmingPool: Width = " + firePool.getWidth() + " Height: " + firePool.getHeight());
            Console.WriteLine("Nkandla Amphitheatre: NumberOfSeats = " + amphi.getNumberOfSeats());

            Politician JacobZuma = new Politician("Jacob Zuma", 43, Gender.MALE, PersonType.President, PartyType.ANC);
            Politician HelenZille = new Politician("Hellen Zille", 50, Gender.FEMALE, PersonType.Politician, PartyType.DA);
            Politician JuliusMalema = new Politician("Julius Malema", 38, Gender.MALE, PersonType.Politician, PartyType.EFF);

            Lawer BarryRoux = new Lawer("Barry Roux", 55, Gender.MALE, PersonType.Lawyer, PartyType.ANC);
            Architect GregWright = new Architect("Greg Wright", 62, Gender.MALE, PersonType.Architect, PartyType.ANC);

            //Output
            Console.WriteLine(JacobZuma.ToString());
            Console.WriteLine(HelenZille.ToString());
            Console.WriteLine(JuliusMalema.ToString());
            Console.WriteLine(BarryRoux.ToString());
            Console.WriteLine(GregWright.ToString());

            home.accept(HelenZille);
            home.accept(JuliusMalema);
            home.accept(JacobZuma);


            Console.Read();

        }
    }
}
