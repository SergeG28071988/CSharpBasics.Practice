using System;
using CSharpBasics.Practice.ConsoleUI.Interfaces;

namespace CSharpBasics.Practice.ConsoleUI.Implementations
{
    /// <summary>
    /// Реализация вывода информации в консоль
    /// </summary>
    /// <seealso cref="IConsoleRenderer"/>
    public class ConsoleRenderer : IConsoleRenderer
    {
        /// <inheritdoc />
        public void PrintHeader(string title)
        {
            Console.WriteLine(new string('=', 40));
            Console.WriteLine(title);
            Console.WriteLine(new string('=', 40));
        }

        /// <inheritdoc />
        /// <remarks>
        /// Числовое значение форматируется с двумя знаками после запятой
        /// </remarks>
        public void PrintResult(string label, double value)
        {
            Console.WriteLine($"{label}: {value:F2}");
        }

        /// <inheritdoc />
        /// <remarks>
        /// Сообщение выводится красным цветом, после чего цвет сбрасывается
        /// </remarks>
        public void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ошибка: {message}");
            Console.ResetColor();
        }
    }
}