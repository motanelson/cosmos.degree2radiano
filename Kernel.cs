using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Cosmosangle
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            while(true)
            {
                double d = 360.00;
                double dd = 16.00;
                double ddd = d / dd;
                double d1 = 2 * Math.PI;
                double d2 = d1 / dd;
                string s = "";
                string ss = "";
                int i  = 0;
            
                Console.BackgroundColor=ConsoleColor.White;
            
                Console.ForegroundColor=ConsoleColor.Black;
                Console.Clear();
                var input = "";// Console.ReadLine();
                for (i = 0; i < 16; i++) 
                { 
                  s= ((double)i * ddd).ToString();
                    if (s.Length > 6)
                    {
                        ss = s.Substring(0,6);

                    }
                    else 
                    {
                        ss = s;
                    
                    
                    }
                    s = ((double)i * d2).ToString();
                    if (s.Length > 6)
                    {
                        s = s.Substring(0,6);

                    }
                    else
                    {
                        s = s;


                    }
                    ss = ss + "\t\t\t\t\t\t\t" + s;
                    Console.WriteLine(ss);
                    ss = "";
                }
                input = Console.ReadLine();
            
                
            }
        }
    }
}
