using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Realizar un programa que pida por consola una contraseña y luego evaluar 
    con el operador de comparación correspondiente para verificar si es igual a 
    la introducida por teclado. 

    Pista: Puedes usar el operador de igualdad que vimos en uno de los videos 
    pero también existe un método de la clase String llamado Equals() el cual 
    es ideal para comparar dos cadenas de texto. Puedes consultar la 
    documentación oficial de .Net para ver cómo funciona
*/

namespace PasswordComparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string PASSWORD = "Iv@n123";

            Console.Write("Password: ");
            string enteredPassword = Console.ReadLine();

            if (enteredPassword.Equals(PASSWORD))
            {
                Console.WriteLine("Success login!");
            }
            else
            {
                Console.WriteLine("Password is not correct!");
            }
        }
    }
}
