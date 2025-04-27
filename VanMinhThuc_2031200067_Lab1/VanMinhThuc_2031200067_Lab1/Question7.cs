namespace VanMinhThuc;

public class Question7
{
    public static void Run()
    {
        Console.WriteLine("----------Question 7---------");
        while (true)
        {
            try
            {
                Console.WriteLine("Enter number: ");
                int inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber <= 0)
                {
                    Console.WriteLine("Input must be a positive integer");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("\n");
                    continue;
                }
                else
                {
                    Console.WriteLine(CalSum(inputNumber));
                }

                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("Input must be integer");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("\n");
            }
        }
    }

    private static int CalSum(int inputNumber)
    {
        int sum = 0;
        for (int i = 1; i <= inputNumber; i++)
        {
            sum += i;
        }

        return sum;
    }
}