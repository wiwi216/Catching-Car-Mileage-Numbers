using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class CarDashboard
    {
        private const string strIncrement = "1234567890";
        private const string strDecrement = "9876543210";

        public int IsInteresting(int number, int[] awesomePhrases)
        {
            if (number < 100) return 0;

            if (awesomePhrases.Contains(number)) return 2;
            if (IsAllZeroFollowed(number)) return 2;
            if (IsAllSameDigit(number)) return 2;
            if (IsPalindromeDigit(number)) return 2;

            if (strIncrement.IndexOf(number.ToString()) >= 0) return 2;
            if (strDecrement.IndexOf(number.ToString()) >= 0) return 2;

            if (this.IsInteresting(number - 1, awesomePhrases) == 2) return 1;
            if (this.IsInteresting(number - 2, awesomePhrases) == 2) return 1;
            return 0;
        }

        private bool IsAllZeroFollowed(int number)
        {
            int[] intArray = IntHelper.digitArr(number);
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] != 0) return false;
            }
            return true;
        }

        private bool IsAllSameDigit(int number)
        {
            int[] intArray = IntHelper.digitArr(number);
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[0] != intArray[i]) return false;
            }
            return true;
        }

        private bool IsPalindromeDigit(int number)
        {
            int[] intArray = IntHelper.digitArr(number);
            for (int i = 0; i < intArray.Length/2; i++)
            {
                if (intArray[i] != intArray[intArray.Length - i - 1]) return false;
            }
            return true;
        }
    }

    public static class IntHelper
    {
        public static int[] digitArr(int n)
        {
            if (n == 0) return new int[1] { 0 };

            var digits = new List<int>();

            for (; n != 0; n /= 10)
                digits.Add(n % 10);

            var arr = digits.ToArray();
            Array.Reverse(arr);
            return arr;
        }
    }
}
