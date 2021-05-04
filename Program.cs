using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace RonAndKanye
{
    class Program
    {
        static void Main(string[] args)

        {
            for (int i = 0; i < 5; i ++)
            {
                QuoteGenerator.KanyeSays();
                Console.WriteLine("");
                QuoteGenerator.RonSays();
                Console.WriteLine("");
            }
            Console.ReadLine();

        }
    }
}
