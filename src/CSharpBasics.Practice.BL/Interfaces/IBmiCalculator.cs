using System;

namespace CSharpBasics.Practice.BL.Interfaces
{
    /// <summary>
    /// Вычисления индекса массы тела (ИМТ)
    /// </summary>
    /// <remarks>
    /// ИМТ — условный показатель, использующийся для оценки
    /// соответствия массы человека и его роста
    /// </remarks>
    public interface IBmiCalculator
    {
        /// <summary>
        /// Вычисляет индекс массы тела по формуле: вес / рост²
        /// </summary>
        /// <param name="weightKg">Вес в килограммах</param>
        /// <param name="heightM">Рост в метрах</param>
        /// <returns>Значение индекса массы тела</returns>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если вес или рост не положительные
        /// </exception>
        /// <example>
        /// <code>
        /// IBmiCalculator calc = new BmiCalculator();
        /// double result = calc.CalculateBmi(70, 1.75); // ~22.86
        /// </code>
        /// </example>
        /// <seealso cref="Implementations.BmiCalculator"/>
        double CalculateBmi(double weightKg, double heightM);
    }
}