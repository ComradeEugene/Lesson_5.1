using System;
using static System.Console;

namespace Lesson_5
{
    class MainClass
    {
        static int WordsCount(string Str, char separator)
        {
            int Flag = 1;
            int Words = 0;
            int Index = 0;

            while (Index < Str.Length)
            {
                if (Str[Index] == separator)
                {
                    Flag = 1;
                }
                else if (Flag == 1)
                {
                    ++Words;
                    Flag = 0;
                }
                ++Index;
            }
            return Words;
        }

        static int WordLength(string Str, int index, char separator)
        {
            int Length = 0;

            while (index < Str.Length)
            {
                if (Str[index] == separator)
                {
                    return Length;
                }
                ++Length;
                ++index;
            }
            return Length;
        }

        static string[] StrSplit(string Str, char separator)
        {
            int index = 0;
            int j = 0;
            string[] arr = new string[WordsCount(Str, separator)];

            while (index < Str.Length)
            {
                if (Str[index] == separator)
                {
                    ++index;
                }
                else
                {
                    arr[j] = Str.Substring(index, WordLength(Str, index, ' '));
                    index += WordLength(Str, index, ' ');
                    ++j;
                }
            }
            return arr;
        }

        static void PrintArr(string[] arr)
        {
            foreach (string e in arr)
            {
                WriteLine(e);
            }
        }

        public static void Main(string[] args)
        {
            WriteLine("Введите предложение");
            string[] Srr = StrSplit(ReadLine(), ' ');
            PrintArr(Srr);
            ReadKey();
        }
    }
}
