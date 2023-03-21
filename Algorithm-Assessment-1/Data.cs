using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Assessment_1
{
    internal class Data
    {
        public class Files




        {
            /*static List<String> fileA = File.ReadAllLines("Road_1_256.txt").ToList();
         public static  List<String> fileB = File.ReadAllLines("Road_1_2048.txt").ToList();
            static List<String> fileC = File.ReadAllLines("Road_2_256.txt").ToList();
            static List<String> fileD = File.ReadAllLines("Road_2_2048.txt").ToList();
            static List<String> fileE = File.ReadAllLines("Road_3_256.txt").ToList();
            static List<String> fileF = File.ReadAllLines("Road_3_2048.txt").ToList();


            //public static //int[] array;// = File.ReadAllLines("Road_1_256.txt").Select(t => Convert.ToInt32(t)).ToArray();


            static  List<int> road_1_256 = fileA.ConvertAll(int.Parse);
          public static List<int> road_1_2048 = fileB.ConvertAll(int.Parse);
            List<int> road_2_256 = fileC.ConvertAll(int.Parse);
            List<int> road_2_2048 = fileD.ConvertAll(int.Parse);
            List<int> road_3_256 = fileE.ConvertAll(int.Parse);
            List<int> road_3_2048 = fileF.ConvertAll(int.Parse);*/

            public static int[] Choice()
            {


                Console.WriteLine("Please select which data you would like to work with.\n\n Please choose from the following options;\n\n A: Road 1 256 data points\n B:Road 1 2048 data points\n\n C: Road 2 256 data points\n D:Road 2 2048 data points\n\n E: Road 3 256 data points\n F:Road 3 2048 data points\n\n ");


                var usrFileChoice = Console.ReadLine();

                if (usrFileChoice == "A" || usrFileChoice == "a")
                {
                    var array = File.ReadAllLines("Road_1_256.txt").Select(t => Convert.ToInt32(t)).ToArray();
                    return array;
                }

                else if (usrFileChoice == "B" || usrFileChoice == "b")
                {
                    int[] array = File.ReadAllLines("Road_1_2048.txt").Select(t => Convert.ToInt32(t)).ToArray();
                    return array;
                }
                else if (usrFileChoice == "C" || usrFileChoice == "c")
                {
                    int[] array = File.ReadAllLines("Road_2_256.txt").Select(t => Convert.ToInt32(t)).ToArray();
                    return array;
                }
                else if (usrFileChoice == "D" || usrFileChoice == "d")
                {
                    int[] array = File.ReadAllLines("Road_2_2048.txt").Select(t => Convert.ToInt32(t)).ToArray();
                    return array;
                }
                else if (usrFileChoice == "E" || usrFileChoice == "e")
                {
                    int[] array = File.ReadAllLines("Road_3_256.txt").Select(t => Convert.ToInt32(t)).ToArray();
                    return array;
                }
                else if (usrFileChoice == "F" || usrFileChoice == "f")
                {
                    int[] array = File.ReadAllLines("Road_3_2048.txt").Select(t => Convert.ToInt32(t)).ToArray();
                    return array;
                }
                else if (usrFileChoice == "G" || usrFileChoice == "g")
                {
                    int[] arrayR1 = File.ReadAllLines("Road_1_256.txt").Select(t => Convert.ToInt32(t)).ToArray();
                   int[] arrarr3 = File.ReadAllLines("Road_3_256.txt").Select(t => Convert.ToInt32(t)).ToArray();
                    int[] array = arrayR1.Concat(arrarr3).ToArray();
                    return array;
                }
                else if (usrFileChoice == "H" || usrFileChoice == "h")
                {
                    int[] array = File.ReadAllLines("Road_3_2048.txt").Select(t => Convert.ToInt32(t)).ToArray().Concat(File.ReadAllLines("Road_2_2048.txt").Select(t => Convert.ToInt32(t)).ToArray().Concat(File.ReadAllLines("Road_3_2048.txt").Select(t => Convert.ToInt32(t)).ToArray())).ToArray();
                    return array;
                }
                else { Console.WriteLine("You seem to have entered an invalid choice please try again"); return Choice(); }

            }


        }


    }
}

    
