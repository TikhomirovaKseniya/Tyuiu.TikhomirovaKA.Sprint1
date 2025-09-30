using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TikhomirovaKA.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {            
            string stroka = number.ToString();
            int index = stroka.IndexOf(',');
            if (index == -1) return false;

            if (index + 1 < stroka.Length && stroka[index + 1] == '0') return true;
            if (index + 2 < stroka.Length && stroka[index + 2] == '0') return true;
            if (index + 3 < stroka.Length && stroka[index + 3] == '0') return true;

            return false;
        }
    }
}
