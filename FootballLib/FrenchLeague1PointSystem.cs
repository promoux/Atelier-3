using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballLib
{
    public class FrenchLeague1PointSystem : PointSystem
    {
        private static FrenchLeague1PointSystem _theInstance;
        private static readonly object padlock = new object();

        protected FrenchLeague1PointSystem(){

        }

        public static FrenchLeague1PointSystem Instance{

            get
            {
                lock (padlock)
                {
                    if (_theInstance == null)
                    {
                        _theInstance = new FrenchLeague1PointSystem();
                    }
                    return _theInstance;
                }
            }
        }

        public override ITotal InitialPoints
        {

            get
            {
                return new PointTotal();
            }

        }
        
        public override ITotal GetPointsFromMatch(Match m,  bool isHome){

            return new PointTotal(m, isHome);
        }

        public class PointTotal : ITotal
        {
            public int _goalaverage;
            public int _points;

            public int CompareTo(object obj)
            {
                return _points - ((PointTotal)obj)._points;
            }
            
            public void  Increment(ITotal with)
            {
                _points += ((PointTotal)with)._points;
                _goalaverage += ((PointTotal)with)._goalaverage;
            }
            
            public PointTotal(){
                _points = 0;
                _goalaverage=0;
            }
            
            public PointTotal(Match m, bool home)
            {
                if (home)
                {
                    _goalaverage += m.HomeGoals - m.AwayGoals;
                }
                else
                    _goalaverage += m.AwayGoals - m.HomeGoals;

                if (m.HomeGoals > m.AwayGoals)
                {
                    if (home)
                    {
                        _points += 3;
                    }
                    else
                    {
                        _points += 0;
                    }
                }
                else if (m.HomeGoals < m.AwayGoals)
                    if (home)
                    {
                        _points += 0;
                    }
                    else
                    {
                        _points += 3;
                    }
                else if(m.HomeGoals == m.AwayGoals){
                    _points +=1;
                }
             }

            public override string ToString()
            {
                return "Points : " + _points + " Goal average : " + _goalaverage;
            }

        }
    }
}
