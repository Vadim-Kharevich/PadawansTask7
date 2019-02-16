using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].Length > array[i + 1].Length)
                {
                    string str = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = str;
                    i = -1;
                }
            }
        }
    }
}
