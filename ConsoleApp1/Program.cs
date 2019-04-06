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
            p.wordCount();
            
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
                string[] words;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    beowolf.Add(ln);
                    counter++;
                   
                }
                words = file.ReadToEnd().Split(' ');
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
                Console.WriteLine(words.Length);
               
                Console.WriteLine();
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

       public int wordCount()
        {
            string inFileName = null;

            Console.WriteLine("Enter the name of the file to process:");
            

            StreamReader sr = new StreamReader(@"U:\Users\732127\arun.txt");

            int counter = 0;
            string delim = " ";
            string[] fields = null;
            string line = null;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
            }



            fields = line.Split(' ');
            for (int i = 0; i < fields.Length; i++)
            {
                counter++;
            }
            sr.Close();
            Console.WriteLine("The word count is {0}", counter);
            return counter;
        }
    }
}
