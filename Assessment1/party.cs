using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment1
{
    class Party
    {
        private string _name;

        public string GetName()
        {
            return _name;
        }
        private int votes { get; set; }
        
        private int _runningVotes;
        public int GetRunningVotes()
        {
            return _runningVotes;
        }
        
        private List<string> meps { get; set; }
        
        private int _seatsSecured;
        public int GetSeatsSecured()
        {
            return _seatsSecured;
        }
     
        public Party(string Name, int Votes, List<string> MEPs)
        {
            _name = Name;
            votes = Votes;
            _runningVotes = votes;
            meps = MEPs;
        }

        public string GetMEPs(int number)
        {
            string MEPs = "";
            for (int i = 0; i < number; i++)
            {
                MEPs = MEPs + "," + meps[i];
            }
            MEPs = MEPs[1..];
            return MEPs;
        }

        public void WinSeat()
        {
            _seatsSecured++;
            _runningVotes = votes / (1 + _seatsSecured);
        }
    }
}
