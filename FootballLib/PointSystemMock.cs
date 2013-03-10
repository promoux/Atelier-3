using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLib
{
    class PointSystemMock : PointSystem.ITotal
    {
        private int points;

        public PointSystemMock()
        {
            this.points = 0;
        }

        public PointSystemMock(Match m, bool home)
        {
            this.points = m.HomeGoals - m.AwayGoals;
        }

        public virtual void Increment(PointSystem.ITotal with)
        {
            this.points += ((PointSystemMock)with).points;
        }

        public int CompareTo(object obj)
        {
            return this.points - ((PointSystemMock)obj).points;
        }
        
        public override string ToString()
        {
            return "Points : " + points ;
        }

    }
}
