using System;
using System.Collections.Generic;
using System.Linq;

namespace WealthTeach
{
    public class Program
    {
        protected string WealthTeach(int number)
        {
            // assuming that calculating the modulus of a number is an expensive operation,
            // let's keep its usage to minimum
            string str = "";

            if (number % 3 == 0) str += "Wealth";
            if (number % 5 == 0) str += "Tech";
            if (str.Length == 0) str += number.ToString();

            return str;
        }

        public void WealthTeach(IEnumerable<int> numbers)
        {
            foreach (var number in numbers.Select(number => WealthTeach(number)))
            {
                Console.Write($"{number} ");
            }
        }

        static void Main(string[] args)
        {
            var p = new Program();

            p.WealthTeach(Enumerable.Range(1, 100));
        }
    }
}
