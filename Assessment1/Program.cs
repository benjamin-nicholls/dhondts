using System;
using System.Collections.Generic;

namespace Assessment1
{

    class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("name: " + pp.name + " with votes: " + pp.votes + " and MEPs: " + pp.GetMEPs());
            }

            int highestVotes = 0;
            int MEPcounter = 0;
            /*while (MEPcounter > 5)
            {
                for (int i = 2; i < lines.Length-1; i++)
                {
                  // lines[i].Split(",")[1]
                }

            }*/






            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}



