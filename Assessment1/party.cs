using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment1
{
    class Party
    {
        public string name { get; private set; }
        public int votes { get; private set; }
        public int runningVotes { get; private set; }
        private  List<string> meps { get; set; }
        public int seatsSecured { get; private set; }
     
        public Party(string Name, int Votes, List<string> MEPs)
        {
            name = Name;
            votes = Votes;
            runningVotes = votes;
            meps = MEPs;
        }

        public string GetMEPs()
        {
            string MEPs = "";
            foreach (string mep in meps)
            {
                MEPs = MEPs + ", " + mep;
            }
            MEPs = MEPs[2..];
            return MEPs;
        }

        public void WinSeat()
        {
            seatsSecured++;
            runningVotes = votes / (1 + seatsSecured);
        }

    }
}
