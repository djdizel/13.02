using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02
{

    internal class Calculate
    {
        /// <summary>
        /// Объявление полей
        /// </summary>
        public double field1;
        public double field2;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Calculate() { }
        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="field1"></param>
        public Calculate(double field1) 
        { 
            this.field1 = field1; 
        }
        /// <summary>
        ///  Конструктор с 2 параметрами
        /// </summary>
        /// <param name="field1"></param>
        /// <param name="field2"></param>
        public Calculate(double field1, double field2):this(field1) 
        {
            this.field2 = field2;
        }
        /// <summary>
        /// Функция формирования строки с информацией об объекте
        /// </summary>
        //public void Output()
        //{
        //    Console.WriteLine($"field1 = {field1}, field2 = {field2}");
        //}
        public override string ToString()
        {
            return $"field1 = { field1}, field2 = { field2}";
        }
        /// <summary>
        ///  Функция вычисления квадратного поля
        /// </summary>
        /// <returns>field1,field2</returns>
        public double CalculateSquareRoot()
        {
            return Math.Sqrt(field1*field2);
        }


    }
}
