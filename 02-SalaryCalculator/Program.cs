using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    En una empresa se recibe un porcentaje de bono anual dependiendo de 
    cuantos años tenga el empleado laborando. Si el empleado tiene más de un 
    año laborando en la empresa, recibirá un bono del 15% de su mensualidad, 
    si tiene entre 2 y 5 años, recibirá un bono del 20% y si tiene más de 5 años, 
    entonces su bono será del 25%. 

    Realiza un programa que pida por consola dos datos: 
        - La cantidad de años que tienes trabajando en la empresa 
        - Tu salario mensual  

    Deberás realizar este programa con condicionales if-else y deberás mostrar 
    al final la suma de tu mensualidad más el bono.
*/

namespace SalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of years you have worked at the company: ");
            int yearsWorked = int.Parse(Console.ReadLine());

            Console.Write("Enter your monthly salary: $");
            double monthlySalary = double.Parse(Console.ReadLine());

            if (yearsWorked < 1)
            {
                Console.WriteLine($"No bonus, salary remains: ${monthlySalary}");
            }
            else if (yearsWorked < 2)
            {
                Console.WriteLine($"15% bonus. Total: ${monthlySalary * 1.15}");
            }
            else if (yearsWorked <= 5)
            {
                Console.WriteLine($"20% bonus. Total: ${monthlySalary * 1.20}");
            }
            else
            {
                Console.WriteLine($"25% bonus. Total: ${monthlySalary * 1.25}");
            }
        }
    }
}
