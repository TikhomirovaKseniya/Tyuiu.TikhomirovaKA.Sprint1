﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TikhomirovaKA.Sprint1.Task7.V17.Lib
{
    public class DataService : ISprint1Task7V17
    {
        public double Calculate(double x, double y)
        {
            return Math.Round((1 + Math.Sin(Math.Sqrt(Math.Pow(x, 2) + 1))) / Math.Cos(12 * y - 4), 3);
        }
    }
}
