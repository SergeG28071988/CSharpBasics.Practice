# CSharpBasics.Practice
Практическое задание по модулю «Основы программирования на C#».
Консольное приложение: периметр треугольника и индекс массы тела (ИМТ).

## Структура

- `src/CSharpBasics.Practice.BL` — бизнес-логика (калькуляторы)
- `src/CSharpBasics.Practice.ConsoleUI` — консольный интерфейс

UI зависит от BL, но не наоборот.

## Требования

- .NET 10 SDK
- VS Code / Visual Studio / Rider

## Запуск
git clone <URL-репозитория>
cd CSharpBasics.Practice
dotnet run --project src/CSharpBasics.Practice.ConsoleUI

## Пример вывода 
========================================
Практическое задание: Основы C#
========================================
Периметр треугольника (3, 4, 5): 12.00
ИМТ (вес 70 кг, рост 1.75 м): 22.86
