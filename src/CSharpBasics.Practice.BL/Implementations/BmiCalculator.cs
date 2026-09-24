using System;
using CSharpBasics.Practice.BL.Interfaces;

namespace CSharpBasics.Practice.BL.Implementations
{
    /// <summary>
    /// Реализация калькулятора индекса массы тела
    /// </summary>
    /// <remarks>
    /// Формула: ИМТ = вес (кг) / рост² (м²)
    /// </remarks>
    /// <seealso cref="IBmiCalculator"/>
    public class BmiCalculator : IBmiCalculator
    {
        /// <inheritdoc />
        public double CalculateBmi(double weightKg, double heightM)
        {
            // Проверка: вес должен быть положительным
            if (weightKg <= 0)
                throw new ArgumentException("Вес должен быть положительным.");

            // Проверка: рост должен быть положительным
            if (heightM <= 0)
                throw new ArgumentException("Рост должен быть положительным.");

            return weightKg / (heightM * heightM);
        }
    }
}