using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JayXmlSerializer.Domain;

namespace JayXmlSerializer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestClass test = new TestClass()
            {
                FName = "Jason",
                LName = "Stahley"
            };


            Console.WriteLine(test.ToXmlString());
            Console.ReadLine();
        }
    }
}
