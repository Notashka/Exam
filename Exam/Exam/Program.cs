using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Критический путь по цепочке работ:");
                Kritic kr = new Kritic("vvod.csv");
               
                Console.ReadKey();
                
            
        }
    }
}
