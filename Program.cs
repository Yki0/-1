using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    internal class Program
    {
        

    }
    class Firma
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int   Year_of_since { get; set; }

        public void Print()
        {
            Console.WriteLine($"Назвавние: {Name}  Дата основания: {Year_of_since} Дата основания: {Adress} ");

            Console.ReadLine();
        }
    }
}
