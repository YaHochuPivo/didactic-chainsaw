using System;
double Calculate(double number)
{
    double factorial = 1;
    for (int i = 1; i <= number; i++)
    {
        factorial *= i;
    }
    return factorial;
}
double result = 0.0;
double number1, number2;
int choice;
do
{
    
    Console.WriteLine("Выберите операцию:"); 
    Console.WriteLine("1. Сложение");
    Console.WriteLine("2. Вычетание"); 
    Console.WriteLine("3. Умножение");
    Console.WriteLine("4. Деление");
    Console.WriteLine("5. Возвести в степень"); 
    Console.WriteLine("6. Найти квадратный корень из числа"); 
    Console.WriteLine("7. Найти 1% от числа");
    Console.WriteLine("8. Найти факториал");
    Console.WriteLine("9. Выйти");
    Console.WriteLine("Введите номер операции: "); 
    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.Write("Введите первое число: "); 
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            number2 = double.Parse(Console.ReadLine());
            result = number1 + number2;
            Console.WriteLine($"Результат: {result}");
            break;
        case 2:
            Console.Write("Введите первое число: "); 
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            number2 = double.Parse(Console.ReadLine());
            result = number1 - number2;
            Console.WriteLine($"Результат: {result}");
            break;
        case 3:
            Console.Write("Введите первое число: ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            number2 = double.Parse(Console.ReadLine());
            result = number1 * number2;
            Console.WriteLine($"Результат: {result}");
            break;
        case 4:
            Console.Write("Введите первое число: "); 
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            number2 = double.Parse(Console.ReadLine());
            if (number2 != 0)
            {
                result = number1 / number2;
                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Блииин. На ноль делить кажись нельзя...(((((");
            }
            break;
        case 5:
            Console.Write("Введите число: ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Введите степень: ");
            int tuctuc = int.Parse(Console.ReadLine());
            result = Math.Pow(number1, tuctuc);
            Console.WriteLine($"Результат: {result}");
            break;
        case 6:
            Console.Write("Введите число: ");
            number1 = double.Parse(Console.ReadLine());
            result = Math.Sqrt(number1);
            Console.WriteLine($"Результат: {result}");
            break;
        case 7:
            Console.Write("Введите число: "); 
            number1 = double.Parse(Console.ReadLine());
            result = 0.01 * number1;
            Console.WriteLine($"1% числа: {result}");
            break;
        case 8:

            Console.Write("Введите число: "); 
            number1 = double.Parse(Console.ReadLine());
            result = Calculate(number1);
            Console.WriteLine($"Факториал числа: {result}");
            break;
        case 9:
            Console.WriteLine("Сябки за использование. Пока!");
            break;
        default:
            Console.WriteLine("Ошибка.");
            break;
    }
} while (choice != 9);























