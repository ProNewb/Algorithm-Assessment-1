//Algorithm Assessment 1
// Robert Walker 26541297

using Algorithm_Assessment_1;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Algorithms
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("hi");
            Console.ReadLine();

            //  Sort.bubbleSort();
            //Console.WriteLine("\n\n\n\n");
            //Data.Files.Choice();

             Sort.binaryInsersionSort(Data.Files.Choice());
            //Sort.bubbleSort(); 
            // Sort.mergeSort();    nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn
            /*var usr = Data.Files.Choice();
            Sort.QuickSort(usr, 0, usr.Length-1);
            foreach (var item in usr)
                Console.WriteLine(item);

            var us = Data.Files.Choice();
            Sort.mergeSort(us, 0, us.Length - 1);
            foreach (var item in us)
                Console.WriteLine(item);
            // not working foreach (var x in Sort.mergeSort())
            //{
            //Console.WriteLine(x);
            //}
             Console.WriteLine("ttt\n\n\n");
            Console.WriteLine("quick r \n\n\n");


            // Sort.binaryInsersionSortReversed(Data.Files.Choice());
            //Sort.reverseBubbleSort();

            var usr1 = Data.Files.Choice();
            Sort.QuickSortReversed(usr1, 0, usr1.Length - 1);
            foreach (var item in usr1)
                Console.WriteLine(item);


            var us1 = Data.Files.Choice();
            Sort.mergeSortReversed(us1, 0, us1.Length - 1);
            foreach (var item in us1)
                Console.WriteLine(item);
            

            //foreach (var x in Sort.mergeSortReversed(Data.Files.Choice()))
            //{ Console.WriteLine(x); }




            //foreach (var x in Sort.QuickSort(Data.Files.array, 0, Data.Files.array.Length-1))
            //   Console.WriteLine(x);*/





            var res = Search.linearSearch(Data.Files.Choice());
            if (res == -1)
            { Console.WriteLine("Value does not exist"); }
            else
            {
                Console.WriteLine("Element was found at index "+ res);
            }


            Console.WriteLine("\n\n\n\n");

            var bres = Data.Files.Choice();
            Console.WriteLine("Eneter search value");
            int x = Convert.ToInt32(Console.ReadLine());
           var binaryres = Search.binarySearch(bres, 0, bres.Length, x);
            if (binaryres == -1)
            { Console.WriteLine("Value does not exist"); }
            else
            {
                Console.WriteLine("Element was found at index " + binaryres);
            }
        }
    }
}
