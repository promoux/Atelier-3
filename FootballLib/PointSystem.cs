using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLib
{
    public abstract class PointSystem
    {
        public virtual ITotal InitialPoints
        {
            get
            {
               return new PointSystemMock();
            }
        }

        public virtual ITotal GetPointsFromMatch(Match m, bool isHome)
        {
           return new PointSystemMock(m, isHome);
        }

        public interface ITotal:IComparable
        {
            void Increment(ITotal with);
            string ToString();
        }

    }
}
