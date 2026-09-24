using System;
using CSharpBasics.Practice.BL.Interfaces;

namespace CSharpBasics.Practice.BL.Implementations
{
    /// <summary>
    /// Реализация калькулятора геометрических фигур
    /// </summary>
    /// <remarks>
    /// Класс не хранит состояния — все методы являются чистыми функциями,
    /// зависящими только от входных параметров
    /// </remarks>
    /// <seealso cref="IGeometryCalculator"/>
    public class GeometryCalculator : IGeometryCalculator
    {
        /// <inheritdoc />
        /// <remarks>
        /// Валидация выполняется в два этапа:
        /// 1) проверка положительности сторон;
        /// 2) проверка неравенства треугольника.
        /// </remarks>
        public double CalculateTrianglePerimeter(double a, double b, double c)
        {
            // Проверка: стороны должны быть положительными
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Стороны треугольника должны быть положительными.");

            // Проверка: неравенство треугольника
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Треугольник с такими сторонами не существует.");

            return a + b + c;
        }
    }
}