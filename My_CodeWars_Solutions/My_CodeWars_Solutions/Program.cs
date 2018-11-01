using System;
using System.Collections.Generic;
using System.Linq;

namespace My_CodeWars_Solutions
{
    class Program
    {
        static void Main(string[] args)
        {     
            Console.ReadKey();
        }
        // Bit Counting
        public static int CountBits(int n)
        {
            string binary = Convert.ToString(n, 2);
            var counter = (from char c in binary where c == '1' select c).Count();
            return counter;
        }
        //Friend or Foe?
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            var list = from name in names where name.Length == 4 select name;
            string[] lista = list.ToArray();
            return lista;
        }
        // Find the parity outlier
        public static int Find(int[] integers)
        {

            var even = from nums in integers where nums % 2 == 0 select nums;
            var ueven = from nums in integers where nums % 2 != 0 select nums;
            var evenarray = even.ToArray();
            var unevenarray = ueven.ToArray();
            if (evenarray.Length == 1) return evenarray[0];
            else return unevenarray[0];
        }
        // Vowel Count
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            vowelCount = str.Count(letter => "aeiou".Contains(char.ToLower(letter)));

            return vowelCount;
        }
        //Two to One
        public static string Longest(string s1, string s2)
        {
            char[] sum = (s1 + s2).ToCharArray();
            string solution = "";
            Array.Sort(sum);
            foreach (char letter in sum)
            {
                if (!solution.Contains(letter))
                {
                    solution += letter;
                }
            }

            return solution;
        }
        // Take a Number And Sum Its Digits Raised To The Consecutive Powers And ....¡Eureka!!
        public static long[] SumDigPow(long a, long b)
        {
            List<long> list = new List<long>();


            for (long i = a; i < b; i++)
            {
                double sum = 0;
                char[] number = i.ToString().ToCharArray();
                for (int j = 0; j < number.Length; j++)
                {
                    sum += Math.Pow(Convert.ToDouble(number[j].ToString()), Convert.ToDouble(j + 1));
                }
                if (sum == i)
                {
                    list.Add(i);
                }
            }
            long[] array = list.ToArray();
            return array;
        }
        // Printer Errors
        public class Printer
        {
            public static string PrinterError(String s)
            {
                return (from c in s where c < 'a' || c > 'm' select c).Count() + "/" + s.Length;
            }
        }
        // Sum of the first nth term of Series
        public static string SeriesSum(int n)
        {

            double result = 0;
            double count = 1;
            if (n != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    result += Convert.ToDouble(1 / count);
                    count += 3;
                }
            }
            return Math.Round(result, 2).ToString("0.00");
        }
        //The Supermarket Queue
        public static long QueueTime(int[] customers, int n)
        {
            if (customers.Length > 0)
            {
                if (customers.Length > n)
                {
                    int[] arry = new int[n];
                    for (int i = 0; i < customers.Length; i++)
                    {
                        arry[Array.IndexOf(arry, arry.Min())] += customers[i];
                    }
                    return arry.OrderByDescending(x => x).First();
                }
                else return customers.OrderByDescending(x => x).First();
            }
            return 0;
        }
        //Persistent Bugger.
        public static int Persistence(long n)
        {
            char[] number = n.ToString().ToCharArray();
            int counter = 0;
            while (number.Length > 1)
            {
                double sum = 1;
                foreach (var item in number)
                {
                    sum *= Convert.ToDouble(item.ToString());
                }
                number = sum.ToString().ToCharArray();
                counter++;
            }
            return counter;
        }
    }
}
