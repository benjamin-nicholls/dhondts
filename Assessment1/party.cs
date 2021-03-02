using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment1
{
    class Party
    {
        public string name { get; private set; }
        private int votes { get; set; }
        public int runningVotes { get; private set; }
        private List<string> meps { get; set; }
        public int seatsSecured { get; private set; }
     
        public Party(string Name, int Votes, List<string> MEPs)
        {
            name = Name;
            votes = Votes;
            runningVotes = votes;
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
            seatsSecured++;
            runningVotes = votes / (1 + seatsSecured);
        }
    }
}
