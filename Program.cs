using System.Diagnostics.Metrics;

namespace ChallengeLabsWeek2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int width = 0;
            
            number = GetNumberAndWidth("Please enter a number");
            width = GetNumberAndWidth("Please enter the width");
            CreateTriangle(number, width);
        }


        public static int GetNumberAndWidth(string request)
        {

            Console.WriteLine(request);
            return Convert.ToInt32(Console.ReadLine());


        }

        public static void CreateTriangle(int num1, int num2)
        {
            int[] width = new int[num2];

            for (int i = 0; i < width.Length; i++)
            {
                width[i] = num1;
            }

            for (int i = width.Length-1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(width[j]);
                }
                Console.WriteLine();
            }
            
           
        }
    }
}
