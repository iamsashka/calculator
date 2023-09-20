using System;

class Калькулятор
{
    static void Main(string[] args)
    {
        int выбор;
        double цифорка1, цифорка2;

        while (true)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал числа");
            Console.WriteLine("9. Выйти из программы");

            Console.Write("Введите номер операции: ");
            выбор = Convert.ToInt32(Console.ReadLine());

            if (выбор == 9)
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            switch (выбор)
            {
                case 1:
                    Console.Write("Введите первое число: ");
                    цифорка1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    цифорка2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат: " + (цифорка1 + цифорка2));
                    break;

                case 2:
                    Console.Write("Введите первое число: ");
                    цифорка1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    цифорка2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат: " + (цифорка1 - цифорка2));
                    break;

                case 3:
                    Console.Write("Введите первое число: ");
                    цифорка1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    цифорка2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат: " + (цифорка1 * цифорка2));
                    break;

                case 4:
                    Console.Write("Введите первое число: ");
                    цифорка1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    цифорка2 = Convert.ToDouble(Console.ReadLine());
                    if (цифорка2 != 0)
                        Console.WriteLine("Результат: " + (цифорка1 / цифорка2));
                    else
                        Console.WriteLine("Деление на ноль недопустимо");
                    break;

                case 5:
                    Console.Write("Введите число: ");
                    цифорка1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите степень: ");
                    int exponent = Convert.ToInt32(Console.ReadLine());
                    double result = 1;
                    for (int i = 0; i < exponent; i++)
                    {
                        result *= цифорка1;
                    }
                    Console.WriteLine("Результат: " + result);
                    break;

                case 6:
                    Console.Write("Введите число: ");
                    цифорка1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат: " + Math.Sqrt(цифорка1));
                    break;

                case 7:
                    Console.Write("Введите число: ");
                    цифорка1 = Convert.ToDouble(Console.ReadLine());
                    double процентик = цифорка1 / 100;
                    Console.WriteLine("Результат: " + процентик);
                    break;

                case 8:
                    Console.Write("Введите число: ");
                    int факториал = Convert.ToInt32(Console.ReadLine());
                    long factorial = 1;
                    for (int i = 1; i <= факториал; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine("Результат: " + factorial
                        );
                    break;

                default:
                    Console.WriteLine("Некорректный выбор операции. Попробуйте снова.");
                    break;
            }
        }
    }
}
