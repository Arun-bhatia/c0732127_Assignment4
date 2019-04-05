using System;
using System.Collections;
using System.Collections.Generic;
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
        }
        public void Run()
        {
            this.ReadTextFiles();
        }
        public void ReadTextFiles()
        {
            using(StreamReader file=new StreamReader())
        }
        
    }
}
