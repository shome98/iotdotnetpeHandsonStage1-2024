using System;


namespace JaggedArray      //DO NOT Change the namespace name
{
    public class Program    //DO NOT Change the class name
    {
        public static void Main(string[] args)    //DO NOT change the method signature
        {
            Console.WriteLine("Enter the number of teams:");
            int noofteams = int.Parse(Console.ReadLine());
            int[][] JaggedArray = new int[noofteams][];

            //attempts part
            for (int i = 0; i < JaggedArray.Length; i++)
            {
                Console.WriteLine("No.of attempts for team {0}:", i + 1);
                JaggedArray[i] = new int[int.Parse(Console.ReadLine())];
            }
            for (int i = 0; i < JaggedArray.Length; i++)
            {
                Console.WriteLine("Enter the score for team {0}:", i + 1);
                for (int j = 0; j < JaggedArray[i].Length; j++)
                {
                    
                    JaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            String result = GetTotalScore(JaggedArray);
            Console.WriteLine(result);

        }

        public static String GetTotalScore(int[][] JaggedArray)        //DO NOT change the method signature
        {
            String str = "";

            for (int i = 0; i < JaggedArray.Length; i++)
            {
                int sum =0;
                for (int j = 0; j < JaggedArray[i].Length; j++)
                {
                    sum += JaggedArray[i][j];
                }
                str = str + "Team " + (i+1) + " Total Score is " + sum;

            }
            return str;
            //Implement code here 
            //Method to calculate total score for each team and return a string as specified in the sample output.
        }

    }
}
