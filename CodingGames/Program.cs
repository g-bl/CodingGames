using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
#if DEBUG
using Console = CodingGames.Console;
#endif

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
#if DEBUG
        Console.LoadTestcase("Test04.txt");
        //Console.DebugLoadedFile();
        //Console.Error.WriteLine("Debug messages...");
#endif
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();

            string returnedLine = "";
            foreach (char c in T)
            {
                if (Char.IsLetter(c))
                {
                    int posInAlphabet = (int)c % 32;
                    for (int j = (posInAlphabet - 1) * L; j < (posInAlphabet - 1) * L + L; j++)
                    {
                        returnedLine += ROW[j];
                    }
                }
                else
                {
                    for (int j = ROW.Length - L; j < ROW.Length; j++)
                    {
                        returnedLine += ROW[j];
                    }
                }

            }
            Console.WriteLine(returnedLine);
        }
        
#if DEBUG
        Console.WriteLine("Press any key to exit...");
        Console.End();
#endif
    }
}