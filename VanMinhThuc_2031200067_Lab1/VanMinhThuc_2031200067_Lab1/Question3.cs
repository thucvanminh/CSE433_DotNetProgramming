namespace VanMinhThuc
{
    public class Question3
    {
        public static void Run()
        {
            Console.WriteLine("----------Question 3---------");
            Console.WriteLine("Enter number A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number B: ");
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Sum: " + CalculateSum(a, b));
        }

        public static int CalculateSum(int a, int b)
        {
            return a + b;
        }
    }
}