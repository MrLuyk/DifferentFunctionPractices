using System;
public class Program
{
    static string sM;

    public static void Main(string[] args)
    {
        sM = File.ReadAllText("/workspaces/DifferentFunctionPractices/secretMessage.txt");
        int[] nums = sM.Split(" ").Select(n => Convert.ToInt32(n)).ToArray();

        Console.Clear();
        int count = 0;
        foreach (string num in FizzBuzz(15))
        {
            if (count <= 13)
            {
                Console.Write($"{num}, ");
            }
            else
            {
                Console.Write($"{num}. ");
            }
            count++;
        }
        Console.WriteLine();
    }

    public static string[] FizzBuzz(int n)
    {
        string[] result = new string[n];
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                result[i - 1] = "FizzBuzz";

            else if (i % 3 == 0)
                result[i - 1] = "Fizz";

            else if (i % 5 == 0)
                result[i - 1] = "Buzz";

            else
                result[i - 1] = "" + i;
        }
        return result;
    }

}