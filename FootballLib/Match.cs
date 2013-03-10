using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballLib
{
    public class Match
    {

        private Club _clubHome;
        private Club _clubAway;
        private int _goalsHome;
        private int _goalsAway;
        private bool _isHomeForfeit, _isAwayForfeit;
        //private bool _isDraw;


        public Match(Club clubHome, Club clubAway, int goalsHome, int goalsAway)
        {
            _clubHome = clubHome;
            _clubAway = clubAway;
            _goalsHome = goalsHome;
            _goalsAway = goalsAway;
        }

        public Match(Club clubHome, Club clubAway, bool isHomeForfeit)
        {
            _clubHome = clubHome;
            _clubAway = clubAway;
            _isHomeForfeit = isHomeForfeit;
            _isAwayForfeit = !isHomeForfeit;
        }

        public Club Away
        {
            get
            {
                return _clubAway;
            }
            set
            {
               
            }
        }

        public Club Home
        {
            get
            {
                return _clubHome;
            }
            set
            {
              
            }
        }

        public int AwayGoals
        {
            get
            {
                return _goalsAway;
            }
            set
            {
              
            }
        }


        public int HomeGoals
        {
            get
            {
                return _goalsHome;
            }
            set
            {
               
            }
        }

        public bool isAwayForfeit
        {
            get
            {
                return _isAwayForfeit;
            }
            set
            {
            }
        }

        public bool isDraw
        {
            get
            {
                return (_goalsHome==_goalsAway);
            }
            set
            {
               
            }
        }

        public bool isHomeForfeit
        {
            get
            {
                return (_isHomeForfeit);
            }
            set
            {
            }
           
        }

    }
}
