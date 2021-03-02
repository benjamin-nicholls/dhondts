using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment1
{
    class Party
    {
        public string name { get; private set; }
        public int votes { get; private set; }
        public List<string> meps { get; private set; }
     
        //constructor - do we need this?
        public Party(string Name, int Votes, List<string> MEPs)
        {
            name = Name;
            votes = Votes;
            meps = MEPs; //does this work? to copy an entire array? should we make this a list?--might have to iterate through each element
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
    }
}
