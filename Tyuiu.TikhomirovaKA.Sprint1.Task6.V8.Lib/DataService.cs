using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TikhomirovaKA.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            string[] words = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            for (int i = 0; i < words.Length; i++)
                result += (i > 0 ? " " : "") + words[i].Substring(1) + words[i][0];
            return result;
        }
    }
}
