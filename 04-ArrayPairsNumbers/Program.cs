using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Desarrolla un programa en el que crees e inicialices un array con los
    números del 1 al 10 y luego crea otro array donde introducirás los números
    pares contenidos en el primer array. 
*/

namespace ArrayPairsNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] pairsNumbers = new int[10];
            int index = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    pairsNumbers[index] = numbers[i];
                    index++;
                }
            }

            Array.Resize(ref pairsNumbers, index);

            foreach(int number in pairsNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
