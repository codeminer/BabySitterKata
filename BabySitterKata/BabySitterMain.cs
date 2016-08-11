using BabySitter.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterKata
{
    class BabySitterMain
    {
        static void Main(string[] args)
        {
            Sitter babysitter = new Sitter();
            Console.WriteLine("The pay is " + babysitter.getPayCharge("11 PM", "5 PM", "4 AM"));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
