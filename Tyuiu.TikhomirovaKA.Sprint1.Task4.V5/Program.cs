﻿using Tyuiu.TikhomirovaKA.Sprint1.Task4.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила Тихомирова К. А. | ИБКСб-25-1";

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                       *");
        Console.WriteLine("* Задание #4                                                             *");
        Console.WriteLine("* Вариант #5                                                             *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                               *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
        Console.WriteLine("* вычисляет результат по формуле и печатает его на экране. *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");

        double x, y;
        Console.WriteLine("* Введите X:                                                             *");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("* Введите Y:                                                             *");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");
        
        Console.WriteLine("Ответ: " + ds.Calculate(x, y)); 
        Console.ReadLine();
    }
}