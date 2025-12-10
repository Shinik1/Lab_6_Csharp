using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    /// <summary>
    /// Класс Дробь
    /// </summary>
    public class Fraction : ICloneable, IFractionActions
    {
        private int numerator;      // Числитель дроби
        private int denominator;    // Знаменатель дроби

        /// <summary>
        /// Кэшированное значение вещественного представления дроби
        /// Используется для ускорения повторных вычислений
        /// </summary>
        private double? cachedValue;

        /// <summary>
        /// Доступ к числителю (только чтение)
        /// </summary>
        public int Numerator => numerator;

        /// <summary>
        /// Доступ к знаменателю (только чтение)
        /// </summary>
        public int Denominator => denominator;

        /// <summary>
        /// Конструктор дроби
        /// </summary>
        public Fraction(int num, int den)
        {
            if (den == 0)
                throw new DivideByZeroException("Знаменатель не может быть равен нулю");

            if (den < 0)
            {
                num = -num;
                den = Math.Abs(den);
            }

            numerator = num;
            denominator = den;
        }

        /// <summary>
        /// Сложение дробей
        /// </summary>
        public Fraction Sum(Fraction other)
        {
            return new Fraction(
                numerator * other.denominator + other.numerator * denominator,
                denominator * other.denominator
            );
        }

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        public Fraction Minus(Fraction other)
        {
            return new Fraction(
                numerator * other.denominator - other.numerator * denominator,
                denominator * other.denominator
            );
        }

        /// <summary>
        /// Вычитание целого числа из дроби
        /// </summary>
        public Fraction Minus(int value)
        {
            return new Fraction(
                numerator - value * denominator,
                denominator
            );
        }

        /// <summary>
        /// Умножение дробей
        /// </summary>
        public Fraction Mul(Fraction other)
        {
            return new Fraction(
                numerator * other.numerator,
                denominator * other.denominator
            );
        }

        /// <summary>
        /// Деление дробей
        /// </summary>
        public Fraction Div(Fraction other)
        {
            if (other.numerator == 0)
                throw new DivideByZeroException("Деление на ноль");

            return new Fraction(
                numerator * other.denominator,
                denominator * other.numerator
            );
        }

        // ==== ПЕРЕГРУЗКИ ОПЕРАТОРОВ ====
        public static Fraction operator +(Fraction a, Fraction b) => a.Sum(b);
        public static Fraction operator -(Fraction a, Fraction b) => a.Minus(b);
        public static Fraction operator *(Fraction a, Fraction b) => a.Mul(b);
        public static Fraction operator /(Fraction a, Fraction b) => a.Div(b);

        /// <summary>
        /// Строковое представление дроби
        /// </summary>
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        /// <summary>
        /// Сравнение двух дробей по состоянию
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is not Fraction f)
                return false;

            return numerator == f.numerator && denominator == f.denominator;
        }

        /// <summary>
        /// Получение хэш-кода объекта
        /// </summary>
        public override int GetHashCode()
        {
            return HashCode.Combine(numerator, denominator);
        }

        /// <summary>
        /// Клонирование дроби
        /// </summary>
        public object Clone()
        {
            return new Fraction(numerator, denominator);
        }

        /// <summary>
        /// Получение вещественного значения (с кэшированием)
        /// </summary>
        public double ToDouble()
        {
            if (cachedValue == null)
            {
                cachedValue = (double)numerator / denominator;
            }

            return cachedValue.Value;
        }

        /// <summary>
        /// Установка числителя
        /// </summary>
        public void SetNumerator(int value)
        {
            numerator = value;
            cachedValue = null; // Сброс кэша
        }

        /// <summary>
        /// Установка знаменателя
        /// </summary>
        public void SetDenominator(int value)
        {
            if (value == 0)
                throw new DivideByZeroException("Знаменатель не может быть равен нулю");

            if (value < 0)
                throw new ArgumentException("Знаменатель не может быть отрицательным");

            denominator = value;
            cachedValue = null; // Сброс кэша
        }
    }
}
