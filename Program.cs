using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2desafio3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido");

            bool isValid = true;
            while (isValid)
            {
                try
                {
                    Console.Write("Ingrese un número 'a': ");
                    int a = Int16.Parse(Console.ReadLine());
                    Console.Write("Ingrese un número 'b': ");
                    int b = Int16.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("La suma entre 'a' y 'b' es: " + Operacion.suma(a, b));
                    Console.WriteLine("La resta entre 'a' y 'b' es: " + Operacion.resta(a, b));
                    Console.WriteLine("--------------------------------------------");                    
                    isValid = false;
                }
                catch (Exception e)
                {
                    isValid = true;
                    Console.WriteLine("Uno de los números ingresados es incorrecto.");                    
                    Console.WriteLine("Vuelva a ingresarlos:");
                }
            }
            Console.Write("Pulse una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
