using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLib
{
    public class Club
    {
        private string _name;

        public Club(string name){
            _name = name;
        }

        public override string ToString(){
            return "Club: " + _name;
        }
    }
}
