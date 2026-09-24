using System;
using CSharpBasics.Practice.BL.Implementations;
using CSharpBasics.Practice.BL.Interfaces;
using CSharpBasics.Practice.ConsoleUI.Implementations;
using CSharpBasics.Practice.ConsoleUI.Interfaces;

// Composition root — собираем зависимости вручную
IGeometryCalculator geometry = new GeometryCalculator();
IBmiCalculator bmi = new BmiCalculator();
IConsoleRenderer renderer = new ConsoleRenderer();

renderer.PrintHeader("Практическое задание: Основы C#");

// --- Периметр треугольника ---
double a = 3, b = 4, c = 5;

try
{
    double perimeter = geometry.CalculateTrianglePerimeter(a, b, c);
    renderer.PrintResult($"Периметр треугольника ({a}, {b}, {c})", perimeter);
}
catch (ArgumentException ex)
{
    renderer.PrintError(ex.Message);
}

// --- ИМТ ---
double weight = 102, height = 1.75;

try
{
    double bmiValue = bmi.CalculateBmi(weight, height);
    renderer.PrintResult($"ИМТ (вес {weight} кг, рост {height} м)", bmiValue);
}
catch (ArgumentException ex)
{
    renderer.PrintError(ex.Message);
}

Console.WriteLine();
Console.WriteLine("Нажмите любую клавишу для выхода...");
Console.ReadKey();