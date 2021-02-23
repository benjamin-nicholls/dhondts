using System;
using System.Collections.Generic;

namespace Assessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("input.txt");
            List<List<string>> party = new List<List<string>>();
            for (int x = 2; x < lines.Length - 1; x++)
            {
                string[] sub = lines[x].Split(",");
                for (int y = 0; y < sub.Length; y++)
                {
                //may need to to account for ; at the end 
                    party[x - 2][y] = sub[y];
                }
            }

            Console.WriteLine(party[2][1]);

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



