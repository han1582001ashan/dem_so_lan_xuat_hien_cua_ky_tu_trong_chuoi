using System;
namespace DisplayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your String: ");
            string myString = Console.ReadLine();
            Console.WriteLine("Enter your Char: ");
            char x = Char.Parse(Console.ReadLine());
            Console.WriteLine(x+ " appears "+charCount(myString, x)+" times");
        }

        public static int charCount(string newString, char x)
        {
            int count = 0;
            for (int i = 0; i < newString.Length; i++)
            {
                if (newString[i] == x)
                {
                    count++;
                }
            }
            return count;
        }

    }
}

