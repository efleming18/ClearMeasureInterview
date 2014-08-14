using ForClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearMeasureInterview
{
    public class Program
    {
        private static Calculator _calculator;

        public static void Main(string[] args)
        {
            var endPoint = 100;
            var customRulesList =  new List<ForClient.CustomRule>();
            var resultsToPrint = new List<String>();

            //Add custom rules for client
            customRulesList.Add(new CustomRule(3, "Fizz"));
            customRulesList.Add(new CustomRule(5, "Buzz"));

            _calculator = new ForClient.Calculator(customRulesList);
            PrintResultForXAmount(100);
        }

        private static void PrintResultForXAmount(int numberOfTimesToIterate)
        {
            var resultToOutput = "";
            for (int i = 1; i <= numberOfTimesToIterate; i++)
            {
                resultToOutput += _calculator.ResultGivenInputOf(i);
            }
            Console.WriteLine(resultToOutput);
        }
    }
}
