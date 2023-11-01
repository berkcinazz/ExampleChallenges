using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleChallenges.Extensions
{
    public class StringHelper
    {
        public void WriteToConsoleOfFizzBuzzResult(List<int> nums)
        {
            foreach (int i in nums)
            {
                string result = string.Empty;
                bool isMultiplesOfThree = i % 3 == 0;
                bool isMultiplesOfFive = i % 5 == 0;
                if (isMultiplesOfThree) result = "Fizz";
                if (isMultiplesOfFive) result += "Buzz";
                if (!isMultiplesOfFive && !isMultiplesOfThree) result = i.ToString();
                Console.WriteLine(result);
            }
        }

        public string Sum(string val1, string val2)
        {
            int value1; int value2;
            Int32.TryParse(val1, out value1);
            Int32.TryParse(val2, out value2);
            return (value1 + value2).ToString();
        }
        
        public string Subtract(string val1, string val2)
        {
            int value1; int value2;
            Int32.TryParse(val1, out value1);
            Int32.TryParse(val2, out value2);
            return (value1 - value2).ToString();
        }
    }
}
