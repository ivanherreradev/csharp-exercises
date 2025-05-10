using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Haz un programa que muestre por consola una lista de clientes con sus
    edades. Los clientes y edades deben ser introducidos por teclado y deben
    ser almacenados en arrays (uno para los nombres y otro para las edades).
    La cantidad de clientes debe ser determinada por el propio usuario quién
    deberá introducir este número por teclado y es el que será usado para
    determinar el tamaño de los arrays. Puedes mostrar los clientes con sus
    edades de forma manual pero como vimos en clase, la mejor forma de
    hacerlo es a través de bucles. 
*/

namespace ArrayRegisterClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of clients to enter: ");
            int numberOfClients = int.Parse(Console.ReadLine());

            string[] clientsNames = new string[numberOfClients];
            int[] clientsAges = new int[numberOfClients];

            for (int i = 0; i < numberOfClients; i++)
            {
                Console.Write($"Enter the client's name {i+1}: ");
                string name = Console.ReadLine();

                Console.Write($"Enter the client's age {i + 1}: ");
                int age = int.Parse(Console.ReadLine());

                clientsNames[i] = name;
                clientsAges[i] = age;
            }

            Console.WriteLine("Client list:");
            Console.WriteLine("------------------------");
            for (int i = 0; i < numberOfClients; i++)
            {
                Console.WriteLine($"Name: {clientsNames[i]} - age: {clientsAges[i]}");
            }
        }
    }
}
