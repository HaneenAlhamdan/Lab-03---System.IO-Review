using System;
using System.IO;


namespace Lab03System.IOReview
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //String Path = "words.txt";
                //String word = "Welcome";

              
                Console.WriteLine("The product of these 3 numbers is:" + challenge_One(Inesrt_One()));

                challenge_Two();

                challenge_Three();

                int[] arr1 = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
                Console.WriteLine(" output :" + challenge_Four(arr1));

                int[] arr2 = { 5, 25, 99, 123, 78, 96, 555, 108, 4 };
                Console.WriteLine(" The maximm : " + challenge_Five(arr2));

                // challenge_Six(Path, word);
                // challenge_Seven(Path, word);

                //challenge_Eight();

                Console.Write("Please enter your sentence: ");
               string input = Console.ReadLine();
                challenge_Nine(input);



            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.Message);
            }

        }
        public static String Inesrt_One()
        {
            Console.WriteLine("Please enter three number :");
            string number = Console.ReadLine();
            return number;
        }



        public static int challenge_One(String number)
        {

            int result = 1;
            string[] arr = number.Split(" ");
            if (arr.Length < 3)
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
                Console.WriteLine($"The average of these " + num + " numbers is: " + average);

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

        public static int challenge_Four(int[] arr)
        {
            int temp = 0;
            int maximm = 0;
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        temp++;
                    }
                }
                if (temp > maximm)
                {
                    maximm = temp;
                    result = arr[i];
                }
                temp = 0;
            }
            return result;

        }

        public static int challenge_Five(int[] arr)
        {
            int maximm = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maximm)
                {
                    maximm = arr[i];
                }
            }
            return maximm;
        }


        public static void challenge_Six(String Path, String word)
        {
            Console.WriteLine("Please enter any word: ");
            word = Console.ReadLine();
            {
                if (File.Exists(Path))
                {
                    File.AppendAllText(Path, word + Environment.NewLine);
                }
            }
        }

        public static void challenge_Seven(String Path, String word)
        {
            String path = "words.txt";
            String[] fileContent = File.ReadAllLines(path);
            for (int i = 0; i < fileContent.Length; i++)
                Console.WriteLine(fileContent[i]);
        }

        public static void challenge_Eight()
        {

        }

        public static string[] challenge_Nine(string input)
        {
            string[] inputArr = input.Split();
            string[] outputArr = new string[inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++)
            {
                outputArr[i] = $"{inputArr[i]} : {inputArr[i].Length} / ";
                Console.Write(outputArr[i]);
            }
            return outputArr;
        }
    }
}
