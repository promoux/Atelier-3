using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballLib;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            Club c1 = new Club("Bordeaux");
            Club c2 = new Club("Marseille");
            Club c3 = new Club("Lyon");
            Club[] clubs = new Club[]{c1,c2,c3};

            Match m = new Match(c1, c2, 3, 1);
            Match m2 = new Match(c1, c3, 2, 2);
            Match m3 = new Match(c1, c3, 10, 1);

            FrenchLeague1PointSystem fr = FrenchLeague1PointSystem.Instance;
         
            Ranking rank = new Ranking(fr,clubs);
            rank.Register(m);
            rank.Register(m2);
            rank.Register(m3);

            Console.WriteLine(c1.ToString() + " - " + rank.EntryFromClub(c1).Points.ToString());
            Console.WriteLine(c2.ToString() + " - " + rank.EntryFromClub(c2).Points.ToString());
            Console.WriteLine(c3.ToString() + " - " + rank.EntryFromClub(c3).Points.ToString());

            Console.ReadLine();
        }
    }
}
