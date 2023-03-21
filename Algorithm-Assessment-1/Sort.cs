using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Algorithm_Assessment_1
{
    //Quickly sort then use slow sort to do ascend descend???
    internal class Sort
    {

        public static void binaryInsersionSort(int[] arr)
        {


            //int[] arr = new int[5] { 8, 5, 7, 3, 1 };
            int n = arr.Length - 1, i, j, val;
            Console.WriteLine("Insertion Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > val)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = val;
            }
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }


        }



        public static void binaryInsersionSortReversed(int[] arr)
        {


            //int[] arr = new int[5] { 8, 5, 7, 3, 1 };
            int n = arr.Length - 1, i, j, val;
            Console.WriteLine("Insertion Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] < val)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = val;
            }
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }


        }

        public static void bubbleSort()
        {
            var data = Data.Files.Choice();
            var count = 0;


            for (int j = 0; j <= data.Length - 2; j++)
            {
                //intArray.Length - 2
                for (int i = 0; i <= data.Length - 2; i++)
                {
                    count = count + 1;
                    if (data[i] > data[i + 1])
                    {
                        int temp = data[i + 1];
                        data[i + 1] = data[i];
                        data[i] = temp;
                    }
                }
            }

            foreach (var item in data)
            {

                Console.WriteLine(item);
            }

        }




        public static void reverseBubbleSort()
        {
            var data = Data.Files.Choice();
            var count = 0;


            for (int j = 0; j <= data.Length - 2; j++)
            {
                //intArray.Length - 2
                for (int i = 0; i <= data.Length - 2; i++)
                {
                    count = count + 1;
                    if (data[i] < data[i + 1])
                    {
                        int temp = data[i + 1];
                        data[i + 1] = data[i];
                        data[i] = temp;
                    }
                }
            }

            foreach (var item in data)
            {

                Console.WriteLine(item);
            }

        }

        public static int[] mergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                mergeSort(array, left, middle);
                mergeSort(array, middle + 1, right);
                MergeArray(array, left, middle, right);
            }
            return array;
        }

        public static void MergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;
            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];
            i = 0;
            j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }
            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }
            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }

        }



         public static int[] mergeSortReversed(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                mergeSortReversed(array, left, middle);
                mergeSortReversed(array, middle + 1, right);
                MergeArrayInReverse(array, left, middle, right);
            }
            return array;
        }

        public static void MergeArrayInReverse(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;
            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];
            i = 0;
            j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] >= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }
            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }
            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }

        }




        public static int[] QuickSort(int[] array, int left, int right)
        {


            List<int> sorted = new List<int>();

            Random ran = new Random();
            int pointer = ran.Next(0, array.Length - 1);

            //select a pivot from the list based on the random number.
            int pivot = array[left];

            //Create two lists for each pivot.Left list will contain the lesser items and right list
            //will contain all the grater items then pivot
            // var left = 0;
            //var right = array.Length - 1;
            var i = left;
            var j = right;

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSort(array, left, j);
            if (i < right)
                QuickSort(array, i, right);


            return array;



        }





        public static int[] QuickSortReversed(int[] array, int left, int right)
        {


            List<int> sorted = new List<int>();

            Random ran = new Random();
            int pointer = ran.Next(0, array.Length - 1);

            //select a pivot from the list based on the random number.
            int pivot = array[left];

            //Create two lists for each pivot.Left list will contain the lesser items and right list
            //will contain all the grater items then pivot
            // var left = 0;
            //var right = array.Length - 1;
            var i = left;
            var j = right;

            while (i <= j)
            {
                while (array[i] > pivot)
                {
                    i++;
                }

                while (array[j] < pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSortReversed(array, left, j);
            if (i < right)
                QuickSortReversed(array, i, right);


            return array;



        }

    }
}
    







   