using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        ArrayList beowolf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.beowolf = new ArrayList();
            p.ReadTextFiles();
            
        }
        public void Run()
        {
            this.ReadTextFiles();
        }
        public void ReadTextFiles()
        {
            using(StreamReader file=new StreamReader(@"U:\Users\732127\arun.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    beowolf.Add(ln);
                    counter++;
                }

                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }
        
        public int FindNumberOfBlankspaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;

            foreach(char c in line)
            {
                if (char.IsLetter(c))
                {
                    countletters++;
                }
                if (char.IsWhiteSpace(c))
                {
                    countSpaces++;
                }
                
            }
            return countSpaces;
        }

       
    }
}
