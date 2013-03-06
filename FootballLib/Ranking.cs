using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballLib
{
    public class Ranking
    {
        private RankingEntry[] _entries;
        private PointSystem _system;

        public Ranking(PointSystem system, Club[] clubs)
        {
            _system = system;
            _entries = new RankingEntry[clubs.Length];
            for (int i = 0; i < clubs.Length; i++)
                _entries[i] = new RankingEntry(clubs[i], system.InitialPoints);
        }

        public RankingEntry EntryFromClub(Club c)
        {
            foreach (RankingEntry entry in _entries)
                if (entry.Club == c)
                    return entry;
            return null;
        }

        public Club GetClub(int index)
        {
            return _entries[index].Club;
        }

        public FootballLib.PointSystem.ITotal GetPoints(int index)
        {
            return _entries[index].Points;
        }
        public FootballLib.PointSystem.ITotal GetPoints(Club club)
        {
            return EntryFromClub(club).Points;
        }

        public void Register(Match m)
        {
            EntryFromClub(m.Home).Points.Increment(_system.GetPointsFromMatch(m, true));
            EntryFromClub(m.Away).Points.Increment(_system.GetPointsFromMatch(m, false));
            Array.Sort(_entries);
        }


        public class RankingEntry:IComparable
        {
            private Club club;
            private FootballLib.PointSystem.ITotal points;

            public RankingEntry(Club club, FootballLib.PointSystem.ITotal points)
            {
                this.club = club;
                this.points = points;
            }

            public Club Club
            {
                 get { return this.club; }
            }

            public FootballLib.PointSystem.ITotal Points
            {
                    get { return this.points; }
         
            }

            #region IComparable Membres

            public int CompareTo(object obj)
            {
                return -this.points.CompareTo(((RankingEntry)obj).Points);
            }

            #endregion

        }
    }
}
