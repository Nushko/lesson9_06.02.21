using System;
using System.Security.Cryptography.X509Certificates;

namespace lesson9_06._02._21
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ReadKey();
                Console.Beep();
            }
            //Должно работать...
        }
    }

    public static class ArrayHelper
    {

        //Pop

        public static T Pop<T>(ref T[] arr)
        {
            if (arr.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Массив пуст.");
                Console.ForegroundColor = ConsoleColor.White;
                return default;
            }

            T x = arr[^1];
            Array.Resize(ref arr, arr.Length - 1);
            return x;
        }

        //Push

        public static int Push<T>(ref T[] arr, T add)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[^1] = add;
            return arr.Length;
        }

        //Shift

        public static T Shift<T>(ref T[] arr)
        {
            if (arr.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Массив пуст.");
                Console.ForegroundColor = ConsoleColor.White;
                return default;
            }

            Array.Reverse(arr);
            T x = arr[^1];
            Array.Resize(ref arr, arr.Length - 1);
            Array.Reverse(arr);
            return x;
        }
        
        //UnShift

        public static int UnShift<T>(ref T[] arr, T add)
        {
            Array.Reverse(arr);
            Array.Resize(ref arr, arr.Length + 1);
            arr[^1] = add;
            Array.Reverse(arr);
            return arr.Length;
        }

        //Slice

        public static T[] Slice<T>(T[] arr)
        {
            return arr;
        }

        public static T[] Slice<T>(T[] arr, int begin)
        {
            if (begin > arr.Length)
            {
                return default;
            }

            if (begin < 0)
            {
                begin = arr.Length - Math.Abs(begin);
            }

            int sz = arr.Length - begin;
            T[] arrnew = new T[sz];
            for (int i = 0; i < sz; i += 1)
            {
                arrnew[i] = arr[begin + i];
            }
            return arrnew;
        }

        public static T[] Slice<T>(T[] arr, int begin, int end)
        {
            if (begin > arr.Length)
            {
                T[] fra = new T[0];
                return fra;
            }

            if (begin < 0)
            {
                begin = arr.Length - Math.Abs(begin);
            }

            if (end < 0)
            {
                end = arr.Length - Math.Abs(end);
            }

            int sz = end - begin;
            T[] arrnew = new T[sz];
            for (int i = 0; i < sz; i += 1)
            {
                arrnew[i] = arr[begin + i];
            }
            return arrnew;
        }
    }
}
