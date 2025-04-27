namespace VanMinhThuc
{
    public class Question4
    {
        public static void Run()
        {
            Console.WriteLine("----------Question 4---------");
            Console.WriteLine("Enter number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b: ");
            int b = int.Parse(Console.ReadLine());
            swapNumber(a,b);
        }

        public static void swapNumber(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}