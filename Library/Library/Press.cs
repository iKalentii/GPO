﻿using System;

namespace Library
{

    /// <remarks>
    ///  Класс Press
    ///  класс программы, осуществляющий вычисления
    ///  при выборе пользователем вида спорта такого как "Press"
    /// </remarks>
    public class Press : IPractice
    {
        private readonly double _weight;
        private readonly int _repetitions;
        private readonly int _sets;

        /// <summary>
        /// Конструктор класса Press
        /// </summary>
        /// <param name="weight"> вес </param>
        /// <param name="repetitions"> количество повторений </param>
        /// <param name="sets"> количество подходов </param>
        public Press(double weight, int repetitions, int sets)
        {
            try
            {
                //TODO: получить исключение FormatException здесь невозможно, а вот присвоить double.NaN и double.*Infinite вполне, лучше проверить на это
                //TODO: и в других классах тоже
                _weight = weight;
                _repetitions = repetitions;
                _sets = sets;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error. You entered is not a number");
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
            var result = ((_weight * _repetitions) * 0.2) * _sets;
            return result;
        }
    };
}
