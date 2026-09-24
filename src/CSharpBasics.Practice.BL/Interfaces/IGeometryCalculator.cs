using System;

namespace CSharpBasics.Practice.BL.Interfaces
{
    /// <summary>
    /// Вычисления, связанные с геометрическими фигурами
    /// </summary>
    /// <remarks>
    /// Интерфейс выделен для возможности подмены реализации
    /// (например, в юнит-тестах или при добавлении новых формул)
    /// </remarks>
    public interface IGeometryCalculator
    {
        /// <summary>
        /// Вычисляет периметр треугольника по трём сторонам
        /// </summary>
        /// <param name="a">Первая сторона треугольника</param>
        /// <param name="b">Вторая сторона треугольника</param>
        /// <param name="c">Третья сторона треугольника</param>
        /// <returns>Периметр треугольника</returns>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если сторона не положительная,
        /// либо если треугольник с такими сторонами не существует
        /// </exception>
        /// <example>
        /// <code>
        /// IGeometryCalculator calc = new GeometryCalculator();
        /// double result = calc.CalculateTrianglePerimeter(3, 4, 5); // 12
        /// </code>
        /// </example>
        /// <seealso cref="Implementations.GeometryCalculator"/>
        double CalculateTrianglePerimeter(double a, double b, double c);
    }
}