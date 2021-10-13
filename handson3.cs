using System;
namespace Increment
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i = 0;
            str = Console.ReadLine();
            char[] inc = new char[str.Length];
            while (i < str.Length)
            {
                if ((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z'))
                {
                    inc[i] = str[i];
                }
                inc[i]++;
                i++;
            }
            Console.Write(inc);
        }
    }
}
