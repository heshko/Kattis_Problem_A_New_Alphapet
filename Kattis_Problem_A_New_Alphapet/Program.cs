using System;
using System.Collections.Generic;

namespace Kattis_Problem_A_New_Alphapet
{
    class Program
    {
       static Dictionary<string, string> alphapet = new Dictionary<string, string>();
        static void Main(string[] args)
        {
           
            alphapet.Add("a", "@");
            alphapet.Add("b", "8");
            alphapet.Add("c", "(");
            alphapet.Add("d", "|)");
            alphapet.Add("e", "3");
            alphapet.Add("f", "#");
            alphapet.Add("g", "6");
            alphapet.Add("h", "[-]");
            alphapet.Add("i", "|");
            alphapet.Add("j", "_|");
            alphapet.Add("k", "|<"); 
            alphapet.Add("l", "1");
            alphapet.Add("m", @"[]\/[]");
            alphapet.Add("n", @"[]\[]");
            alphapet.Add("o", "0");
            alphapet.Add("p", "|D");
            alphapet.Add("q", "(,)");
            alphapet.Add("r", "|Z");
            alphapet.Add("s", "$");
            alphapet.Add("t", "']['");
            alphapet.Add("u", "|_|");
            alphapet.Add("v", @"\/");
            alphapet.Add("w", @"\/\/");
            alphapet.Add("x", "}{");
            alphapet.Add("y", "`/");
            alphapet.Add("z", "2");

            Communication(Console.ReadLine().ToLower());
            Console.WriteLine("Hello World!");
        }

        public static void Communication(string sentance)
        {
            string newSentance =null;
            for (int i = 0; i < sentance.Length; i++)
            {
               
                if (alphapet.ContainsKey(sentance[i].ToString()))
                {
                    newSentance += alphapet.GetValueOrDefault(sentance[i].ToString());
                }
                else
                {
                    newSentance += sentance[i];
                }
            }
            Console.WriteLine(newSentance);
        }
    }
}
