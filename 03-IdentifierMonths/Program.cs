using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Realiza una aplicación que le pida al usuario por consola un número del 1 
    al 12. En un condicional switch, deberás evaluar cada uno de los casos y 
    según el caso correcto, mostrar por consola el mes que corresponda a ese 
    número. Por ejemplo, si el usuario introduce un 5, entonces el mensaje que 
    debe aparecer por consola es “Mayo”. Colocar también un mensaje en caso 
    de que el usuario introduzca un número que no se encuentre entre el 1 y 
    12.
*/

namespace IdentifierMonths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 1 to 12 and the corresponding month will be displayed on the screen.");
            Console.Write("Enter a number: ");

            int numberOfMonth = int.Parse(Console.ReadLine());

            switch(numberOfMonth)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("The number entered does not correspond to a month");
                    break;
            }

        }
    }
}
