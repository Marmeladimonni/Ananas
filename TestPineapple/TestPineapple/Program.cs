using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPineapple
{
    class Program
    {
        /// <summary>
        /// Tää on hieno pääohjelma
        /// </summary>
        /// <param name="args">turhaa paskaa</param>
        static void Main(string[] args)
        {
            Hullo("Derp");
        }
        /// <summary>
        /// Tulostaa näytölle annetun tekstin
        /// </summary>
        /// <param name="teksti">Tulostettava teksti</param>
        static void Hullo(string teksti)
        {
            Console.WriteLine(teksti); //eeppinen kommentti
        }

    }
}