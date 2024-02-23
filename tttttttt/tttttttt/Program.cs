using System;

namespace App
{

    class Cube 
    {
        public int Score { get; set; }

        public void Combination(int[] array)
        {
       
        }
    }


    class Program
    {

        public static void Sort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public static int[] Player1(int[] array) 
        {

            int step = 0;

            Random rnd = new Random();

            Console.WriteLine("Player 1, roll the dice\n");

            Console.WriteLine("Rolling...\n");
            Thread.Sleep(500);

            array[1] = rnd.Next(1, 7);
            array[2] = rnd.Next(1, 7);
            array[3] = rnd.Next(1, 7);
            array[4] = rnd.Next(1, 7);
            array[5] = rnd.Next(1, 7);

            Console.WriteLine("Your dice: " + array[1] + " " + array[2] + " " + array[3] + " " + array[4] + " " + array[5]);

            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("Are you want change some dice? ( 0 - no, 1 - yes)");
                step = Convert.ToInt32(Console.ReadLine());

                if (step == 0)
                {
                    step = -1;
                    break;
                }
                else if (step == 1)
                {
                    Console.WriteLine("Choose, how much dice you want to switch");

                    step = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Choose, dice that you want switch");

                    int[] swap = new int[5];
                    for (int j = 0; j < step; j++)
                    {
                        swap[j] = Convert.ToInt32(Console.ReadLine());
                    }


                    Console.WriteLine("Rolling...\n");
                    Thread.Sleep(500);

                    for (int j = 0; j < step; j++)
                    {
                        array[swap[j]] = rnd.Next(1, 7);
                    }

                    Console.WriteLine("Your dice: " + array[1] + " " + array[2] + " " + array[3] + " " + array[4] + " " + array[5]);
                }

            }

            Sort(array);

            Console.WriteLine("\n\tYour dice in end: " + array[1] + " " + array[2] + " " + array[3] + " " + array[4] + " " + array[5]);

            return array;
        }

        public static int[] Player2(int[] array)
        {

            int step = 0;

            Random rnd = new Random();

            Console.WriteLine("Player 2, roll the dice\n");

            Console.WriteLine("Rolling...\n");
            Thread.Sleep(500);

            array[1] = rnd.Next(1, 7);
            array[2] = rnd.Next(1, 7);
            array[3] = rnd.Next(1, 7);
            array[4] = rnd.Next(1, 7);
            array[5] = rnd.Next(1, 7);

            Console.WriteLine("Your dice: " + array[1] + " " + array[2] + " " + array[3] + " " + array[4] + " " + array[5]);

            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("Are you want change some dice? ( 0 - no, 1 - yes)");
                step = Convert.ToInt32(Console.ReadLine());

                if (step == 0)
                {
                    step = -1;
                    break;
                }
                else if (step == 1)
                {
                    Console.WriteLine("Choose, how much dice you want to switch");

                    step = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Choose, dice that you want switch");

                    int[] swap = new int[5];
                    for (int j = 0; j < step; j++)
                    {
                        swap[j] = Convert.ToInt32(Console.ReadLine());
                    }


                    Console.WriteLine("Rolling...\n");
                    Thread.Sleep(500);

                    for (int j = 0; j < step; j++)
                    {
                        array[swap[j]] = rnd.Next(1, 7);
                    }

                    Console.WriteLine("Your dice: " + array[1] + " " + array[2] + " " + array[3] + " " + array[4] + " " + array[5]);
                }

            }


            Sort(array);

            Console.WriteLine("\n\tYour dice in end: " + array[1] + " " + array[2] + " " + array[3] + " " + array[4] + " " + array[5]);

            return array;
        }

        static void Main(string[] args)
        {
            int[] arr1 = new int[6];
            int[] arr2 = new int[6];

            int[] arrayscore1 = new int[6];

            Console.WriteLine("\tFirst round");

            arrayscore1 = Player1(arr1);

            Console.WriteLine("-------------------------------------\n\tNext player\n-------------------------------------\n");


            int[] arrayscore2 = new int[6];

            Console.WriteLine("\tFirst round");

            arrayscore2 = Player2(arr1);

        }

    }
}