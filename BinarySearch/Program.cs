using System;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int number = 18;

            int result = BinarySearch(numbers, number);

            if (result != -1)
                Console.WriteLine("The value you searched for was found at index {0}.", result);
            else
                Console.WriteLine("The value you searched for does not exist..");
        }

        public static int BinarySearch(int[] array, int number)
        {
            int left = 0;
            int right = array.Length - 1;
            while (right >= left)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == number)
                    return mid;

                if (array[mid] < number)
                    left = mid + 1;

                else
                    right = mid - 1;
            }

            return -1;
        }
    }
}
