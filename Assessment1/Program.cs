using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment1
{

    class Program
    {
        static void Main(string[] args)
        {
            int maxSeatsCount = 5; // East Midlands (European Parliament Constituency)
            int allocatedSeatsCount = 0;
            string[] lines = System.IO.File.ReadAllLines("input.txt");
            List<Party> parties = new List<Party>();

            // Extract party name, votes, and list of MEPs -- create new objects for each party
            for (int x = 2; x < lines.Length; x++)
            {
                // Name and votes stored in 0 and 1 indexes
                string[] sub = lines[x].Split(",");
                List<string> meps = new List<string>();
                // Get all MEPs in a list, remove trailing semicolon
                for (int i = 2; i < sub.Length; i++)
                {
                    if (sub[i].Substring(sub[i].Length - 1, 1) == ";")
                    {
                        meps.Add(sub[i].Split(";")[0]);
                    }
                    else
                    {
                        meps.Add(sub[i]);
                    }
                }
                Party p = new Party(sub[0], int.Parse(sub[1]), meps);
                parties.Add(p);
            }

            //TESTING
            foreach (Party pp in parties)
            {
                //Console.WriteLine($"NAME: {pp.name}. VOTES: {pp.votes}. MEPs: {pp.GetMEPs()}.");
            }


            //Console.WriteLine(parties.Max(r => r.votes));
            Party mostVotes = parties.Aggregate((i1, i2) => i1.runningVotes > i2.runningVotes ? i1 : i2);
            Console.WriteLine(mostVotes.name);
            mostVotes.WinSeat();
            allocatedSeatsCount++;


            //old
            int highestVotes = 0;



            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
        // method to do the maths or something idk
        private static void DHondt()
        {
        }
    }
}



