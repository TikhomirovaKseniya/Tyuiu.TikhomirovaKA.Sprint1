using Tyuiu.TikhomirovaKA.Sprint1.Task2.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила Тихомирова К. А. | ИБКСб-25-1";

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                       *");
        Console.WriteLine("* Задание #2                                                             *");
        Console.WriteLine("* Вариант #3                                                             *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                               *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране. *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        int value;
        Console.WriteLine("* Введите время в часах:                                                 *");
        value = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        Console.WriteLine(ds.ConvertHourToMin(value) + " минут");
        Console.ReadLine();
    }
}