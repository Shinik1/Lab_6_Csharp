using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    /// <summary>
    /// Интерфейс для дополнительных методов дроби
    /// </summary>
    public interface IFractionActions
    {
        /// <summary>
        /// Получение вещественного значения
        /// </summary>
        double ToDouble();

        /// <summary>
        /// Установка числителя
        /// </summary>
        void SetNumerator(int value);

        /// <summary>
        /// Установка знаменателя
        /// </summary>
        void SetDenominator(int value);
    }
}
