using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"..\..\..\..\Data\Input.txt"))
            {
                while (sr.Peek() != -1)
                {
                    string line = sr.ReadLine();
                    foreach (var ch in line)
                    {
                        if (ch.ToString() == ".")
                        {
                            Console.Write(".\n");
                            continue;
                        }
                        if (ch.ToString() == "?")
                        {
                            Console.Write("?\n");
                            continue;
                        }
                        if (ch.ToString() == "!")
                        {
                            Console.Write("!\n");
                            continue;
                        }
                        else
                            Console.Write(ch);
                    }
                }
            }
        }
    }
}


