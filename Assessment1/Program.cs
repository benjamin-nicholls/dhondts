using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Assessment1
{
    class Program
        // gdsudsyavjh
    {
        static void Main(string[] args)
        {
            string inputFileName = "input.txt";
            string outputFileName = "output.txt";

            string[] lines = System.IO.File.ReadAllLines(inputFileName);
            string constituency = lines[0][1..]; // remove leading hash
            int maxSeatsCount = int.Parse(lines[1]);
            int allocatedSeatsCount = 0;
            List<Party> parties = new List<Party>();

            // Extract party name, votes, and list of MEPs -- create new objects for each party
            // x=3 to miss first 3 lines of input file
            for (int x = 3; x < lines.Length; x++)
            {
                // Name and votes stored in 0 and 1 indexes
                string[] sub = lines[x].Split(",");
                List<string> meps = new List<string>();
                // Get all MEPs in a list, remove trailing semicolon
                // i=2 to miss name and votes from each line
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

            // Find the party with the most votes, apply D'Hondt, change tallies
            while (allocatedSeatsCount < 5)
            {
                Party mostVotes = parties.Aggregate((i1, i2) => i1.runningVotes > i2.runningVotes ? i1 : i2);
                mostVotes.WinSeat();
                allocatedSeatsCount++;
            }

            // Prepare strings to output
            List<string> outputList = new List<string>();
            outputList.Add("#" + constituency);
            foreach (Party p in parties)
            {
                 if (p.seatsSecured > 0)
                 {
                     outputList.Add(p.name + "," + p.GetMEPs(p.seatsSecured) + ";");
                 }
            }

            // Creation and printing to the output file
            StreamWriter sw = new StreamWriter(outputFileName);
            
            foreach(string line in outputList)
            {
                sw.WriteLine(line);
                //write to file using line + \n
                // close file
            }
            sw.Close();

            //using StreamWriter file = new(outputFileName);

        }
        // method to do the maths or something idk
        private static void DHondt()
        {
        }
    }
}



