namespace CSharpBasics.Practice.ConsoleUI.Interfaces
{
    /// <summary>
    /// Вывод информации в консоль
    /// </summary>
    /// <remarks>
    /// Интерфейс абстрагирует UI, что позволяет заменить консоль
    /// на файл, логгер или графический интерфейс без изменения
    /// бизнес-логики
    /// </remarks>
    public interface IConsoleRenderer
    {
        /// <summary>
        /// Печатает заголовок раздела
        /// </summary>
        /// <param name="title">Текст заголовка</param>
        void PrintHeader(string title);

        /// <summary>
        /// Печатает результат вычисления
        /// </summary>
        /// <param name="label">Подпись результата</param>
        /// <param name="value">Числовое значение результата</param>
        void PrintResult(string label, double value);

        /// <summary>
        /// Печатает сообщение об ошибке
        /// </summary>
        /// <param name="message">Текст ошибки</param>
        void PrintError(string message);
    }
}