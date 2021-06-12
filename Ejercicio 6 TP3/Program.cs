using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_6_TP3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double Gin, Ped,num;

            Console.WriteLine("Ingrese el Importe");
            num = Convert.ToDouble(Console.ReadLine());

            Gin = (num* 40)/100;
            Ped = (num* 30)/100;
            
            Console.WriteLine ("Ginecologia:  $ {0} ", Gin);
            Console.WriteLine ("Traumatologia: $ {0} ", Ped);
            Console.WriteLine ("Pediatria: $ {0} ", Ped);
            Console.ReadKey();


        }
    }
}
