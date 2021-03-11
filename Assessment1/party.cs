using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment1
{
    class Party
    {
        private string _name;
        private int _votes;
        private int _runningVotes;
        private List<string> _meps;
        private int _seatsSecured;

        public string GetName()
        {
            return _name;
        }

        public int GetRunningVotes()
        {
            return _runningVotes;
        }
        
        public int GetSeatsSecured()
        {
            return _seatsSecured;
        }
     
        public Party(string Name, int Votes, List<string> MEPs)
        {
            _name = Name;
            _votes = Votes;
            _runningVotes = _votes;
            _meps = MEPs;
        }

        public string GetMEPs(int number)
        {
            string MEPs = "";
            for (int i = 0; i < number; i++)
            {
                MEPs = MEPs + "," + _meps[i];
            }
            MEPs = MEPs[1..];
            return MEPs;
        }

        public void WinSeat()
        {
            _seatsSecured++;
            _runningVotes = _votes / (1 + _seatsSecured);
        }
    }
}
