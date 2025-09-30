using Tyuiu.TikhomirovaKA.Sprint1.Task6.V8.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила Тихомирова К. А. | ИБКСб-25-1";

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                       *");
        Console.WriteLine("* Задание #6                                                             *");
        Console.WriteLine("* Вариант #8                                                             *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                               *");
        Console.WriteLine("* Написать программу:                                                    *");
        Console.WriteLine("* Пользователь вводит текст. Напечатать все слова,                       *");
        Console.WriteLine("* перенеся их первую букву в конец                                       *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");

        string value;
        Console.WriteLine("* Введите предложение:                                                   *");
        value = Console.ReadLine();

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        Console.WriteLine(ds.MoveLetterToEnd(value));
        Console.ReadLine();
    }
}