using Tyuiu.TikhomirovaKA.Sprint1.Task1.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила Тихомирова К. А. | ИБКСб-25-1";

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                       *");
        Console.WriteLine("* Задание #1                                                             *");
        Console.WriteLine("* Вариант #9                                                             *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                               *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
        Console.WriteLine("* вычисляет результат по формуле (1+3*x)/(4*y) и печатает его на экране. *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");

        double x, y;

        Console.WriteLine("Введите значение X: ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение Y: ");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        Console.WriteLine(ds.Calculate(x, y));
        Console.ReadLine();
    }
}