using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballLib
{
    public class FrenchLeague1PointSystem : PointSystem
    {
        private static FrenchLeague1PointSystem _theInstance;

        protected FrenchLeague1PointSystem(){

        }

        public static FrenchLeague1PointSystem Instance{

            get{
                if( _theInstance == null )

                    _theInstance = new  FrenchLeague1PointSystem();

                return _theInstance;
                  }
        }

        public ITotal InitialPoint{

            get
            {
                return new PointSystemMock();
            }

        }
        
        public override ITotal GetPointsFromMatch(Match m,  bool isHome){

            return new PointSystemMock(m, isHome);
        }
    }
}
