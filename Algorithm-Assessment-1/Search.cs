using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Assessment_1
{
    internal class Search
    {

        public static int linearSearch(int[] array)
        {
            Console.WriteLine("Eneter search value");
            int x = Convert.ToInt32(Console.ReadLine());
            int N = array.Length;
            for (int i = 0; i < N; i++)
            {
                if (array[i] == x)
                    return i;
            }
            return -1;
        }







        public static int binarySearch(int[] array, int left, int right, int x)
        {
            
            

            if (right >= left)
            {
                int mid = left + (right - left) / 2;

                // If the element is present at the
                // middle itself
                if (array[mid] == x)
                    
                    return mid;

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (array[mid] > x)
                    return binarySearch(array, left, mid - 1, x);

                // Else the element can only be present
                // in right subarray
                return binarySearch(array, mid + 1, right, x);
            }

            // We reach here when element is not present
            // in array
            return -1;
        } 
    }
}
 