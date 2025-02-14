﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _13._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //объект с именем calc,конструктор без параметров
            Calculate calc = new Calculate();     
            Console.WriteLine($"{calc.ToString()}\n");
            calc.Field1 = 2;
            calc.Field2 = 3;
            Console.WriteLine($"{calc.ToString()}\n");
            //конструктор с одним параметрами 
            Calculate calc2 = new Calculate(4);
            Console.WriteLine($"{calc2.ToString()}\n");
            //конструктор с двумя параметрами
            Calculate calc3 = new Calculate(2,3);
            Console.WriteLine($"{calc3.ToString()}\n");
            Console.WriteLine($"{calc3.CalculateSquareRoot()}\n");
            //конструктор с parse
            Console.WriteLine("Введите 1 число");
            double field1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            double field2 = double.Parse(Console.ReadLine());
            Calculate calc4 = new Calculate(field1,field2);
            Console.WriteLine($"{calc4.CalculateSquareRoot()}\n");
            Console.ReadLine();
        }
    }
}
