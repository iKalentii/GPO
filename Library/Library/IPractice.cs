using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <remarks>
    ///  Интерфейс Practice
    ///  описывает основные методы, реализованные в дочерних классах
    /// </remarks>
    public interface IPractice
    {
        //TODO: Лучше использовать свойство с более выраженным названием, сейчас не понятно что за результат рассчитывается
        //TODO: комментарий тоже слишком общий расчёт данных пользователя может рассчитывать что угодно, поэтому лучше уточнить.
        /// <summary>
        /// Метод осуществляет расчет данных пользователя
        /// <returns> 
        /// возвращается количество затраченных калорий  
        /// </returns>
        /// </summary>
        double GetResult();
    };
}
