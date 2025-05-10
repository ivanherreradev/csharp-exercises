using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Crea un array y rellénalo con los días de la semana. Luego pide al usuario
    que introduzca un número del 1 al 7 para saber qué día de la semana tiene
    libre en su trabajo y dependiendo del número introducido, debes mostrar
    por consola el día de la semana correspondiente.

    Nota: Recuerda que las posiciones del array comienzan a partir del cero.
*/

namespace ArrayDaysWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            bool canContinue = true;

            while(canContinue)
            {
                Console.Write("Enter a number from 1 to 7 to display the corresponding day of the week: ");
                int day = int.Parse(Console.ReadLine());
                
                if (day > 0 && day < 8)
                {
                    Console.WriteLine(weekDays[day-1]);
                    canContinue = false;
                }
            }
        }
    }
}
