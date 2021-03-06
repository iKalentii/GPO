﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

    /// <remarks>
    ///  Класс Swimming
    ///  класс программы, осуществляющий вычисления
    ///  при выборе пользователем вида спорта такого как "Swimming"
    /// </remarks>
    public class Swimming : IPractice
    {
        private readonly double _distance;
        private readonly double _style;

        /// <summary>
        /// конструктор класса Swimming
        /// </summary>
        /// <param name="distance"> дистанция заплыва </param>
        /// <param name="style"> стиль плавания </param>
        public Swimming(double distance, double style)
        {
            try
            {
                _distance = distance;
                _style = style;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Error. You entered is not a number");
            }
        }


        /// <summary>
        /// Метод осуществляет расчет данных пользователя
        /// <returns> 
        /// результат возвращается в виде значения типа double 
        /// </returns>
        /// </summary>
        public double GetResult()
        {
            var result = _distance * _style * 1.2;
            return result;
        }
    };
}
