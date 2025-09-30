using Tyuiu.TikhomirovaKA.Sprint1.Task3.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила Тихомирова К. А. | ИБКСб-25-1";

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                       *");
        Console.WriteLine("* Задание #3                                                             *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                               *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране. *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");

        double number;
        Console.WriteLine("* Введите вещественное число:                                            *");
        number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        if (ds.ZeroCheck(number) == true)
        {
            Console.WriteLine("В дробной части этого вещественного числа есть 0");
        }
        else
        {
            Console.WriteLine("В дробной части этого вещественного числа нет 0");
        }
        Console.ReadLine();
    }
}