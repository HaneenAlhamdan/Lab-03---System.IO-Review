using System;

namespace Lab03System.IOReview
{
   public class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 4, 8, 15 };
            // Console.WriteLine("The product of these 3 numbers is:" + challenge_One(Inesrt_Num_One()));
            // challenge_Two();

            //challenge_Three();

            challenge_four();

            //ChallengeSix();
            //ChallengeSeven();

            //  ChallengeEight();
            //int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
            //Console.WriteLine("The product of these 3 numbers is:" + insertNum(arr));


        }
        public static String Inesrt_Num_One()
        {
            Console.WriteLine("Please enter three number :");
            string number = Console.ReadLine();
            return number;
        }



        public static int challenge_One(String number)
        {

            int result = 1;
            string[] arr = number.Split(" ");
            if(arr.Length<3)
            { return 0; }

            if (arr.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {

                    int num = Convert.ToInt32(arr[i]);
                    Type type = typeof(int);
                    Type type1 = num.GetType();
                    if (type != type1)
                    {
                        result = 1;
                        break;
                    }
                    else
                    {
                        result *= num;

                    }

                }
            }




            return result;

        }

        public static void challenge_Two()
        {


            bool runProgram = true;

            while (runProgram)
            {
                Console.WriteLine("Please enter a number between 2-10:");
                int num = Convert.ToInt32(Console.ReadLine());

                double[] array = new double[0];

                double sum = 0;

                if (num < 2 || num > 10)
                {
                    Console.WriteLine("Please try again");
                    runProgram = false;
                }
                else
                {
                    array = new double[num];

                }


                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"please enter number {i + 1} of {array.Length}");

                    double inputNow = Convert.ToDouble(Console.ReadLine());

                    array[i] = inputNow;
                    sum += inputNow;

                }

                double average = sum / num;
                Console.WriteLine($"The average of these " + num +" numbers is: "+ average);

                break;
            }

        }
        public static void challenge_Three()
        {
            int r = 5, i, j;
            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }

        public static void challenge_four()
        {

        }
    }
}
