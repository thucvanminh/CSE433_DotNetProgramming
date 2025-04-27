namespace VanMinhThuc;

public class Question5
{
    public static void Run()
    {
        Console.WriteLine("----------Question 5---------");
        CalAverage();
    }

    public static void CalAverage()
    {
        double total = 0;
        int numberOfGrade = 1;
        try
        {
            Console.WriteLine("How many column of grade do you have?");
            numberOfGrade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter grade {numberOfGrade} times!");
            // int[] grades = new int[numberOfGrade];

            for (int i = 0; i < numberOfGrade; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                // grades[i] = temp;
                total += temp;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Input must be a Integer");
        }


        double average = total / numberOfGrade;
        Console.WriteLine($"Average: {average}");
        if (average >= 90)
        {
            Console.WriteLine("Excellent!");
        }
        else if (average >= 80)
        {
            Console.WriteLine("Good!");
        }
        else if (average >= 70)
        {
            Console.WriteLine("Fair!");
        }
        else
        {
            Console.WriteLine("Average!");
        }
    }
}