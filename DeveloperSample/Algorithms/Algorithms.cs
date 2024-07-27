
using System.Linq;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n) {

                if (n < 0) throw new ArgumentException("Value should be greater than 0");
                else
                {
                    if(n==0) return 1;
                    if (n == 2) return 2;
                    int factorial = n;
                    while (n > 1)
                    {
                        factorial *= n - 1;
                        n--;
                    }
                    return factorial;
                }          
        }
        public static string FormatSeperators(params string[] items)
        {
            if (items == null || items.Length == 0) throw new ArgumentException("Please provide items to format.");
            var res = string.Join(", ", items.SkipLast(1));
            return res+" and "+ items[items.Length-1];
        }
    }
}
