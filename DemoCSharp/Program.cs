using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Set elements: ");
            int elements = Convert.ToInt32(System.Console.ReadLine());

            Network nt = new Network(elements);
            for (int cont = 0; cont < elements; cont++)
            {
                System.Console.WriteLine("Insert element " + (cont + 1));
                int number1 = Convert.ToInt32(System.Console.ReadLine());
                nt.InsertElements(number1);
            }

            System.Console.WriteLine("Number conections: ");
            int conections = Convert.ToInt32(System.Console.ReadLine());

            for (int cont = 0; cont < conections; cont++)
            {

                System.Console.WriteLine("Conection " + (cont + 1));
                int number3 = Convert.ToInt32(System.Console.ReadLine());
                int number4 = Convert.ToInt32(System.Console.ReadLine());
                nt.Connect(number3, number4);
            }

            System.Console.WriteLine("Conection exist? ");

            int number5 = Convert.ToInt32(System.Console.ReadLine());
            int number6 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(nt.Query(number5, number6));

            System.Console.WriteLine("Fim");
            System.Console.ReadLine();




        }
    }
}
