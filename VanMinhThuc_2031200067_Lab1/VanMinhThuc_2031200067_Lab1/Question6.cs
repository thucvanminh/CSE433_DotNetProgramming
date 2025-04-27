namespace VanMinhThuc
{
    public class Question6
    {
        public static void Run()
        {
            Console.WriteLine("----------Question 6---------");
            displayMonth();
        }

        private static void displayMonth()
        {
           Console.WriteLine("Enter number of month: ");
           int month = int.Parse(Console.ReadLine());
           try
           {
               switch (month)
               {
                   case 1:
                       Console.WriteLine("January - Have 31 days");
                       break;
                   case 2:
                       Console.WriteLine("February - Have 28 days");
                       break;
                   case 3:
                       Console.WriteLine("March - Have 31 days");
                       break;
                   case 4:
                       Console.WriteLine("April - Have 30 days");
                       break;
                   case 5:
                       Console.WriteLine("May - Have 31 days");
                       break;
                   case 6:
                       Console.WriteLine("June - Have 30 days");
                       break;
                   case 7:
                       Console.WriteLine("July - Have 31 days");
                       break;
                   case 8:
                       Console.WriteLine("August - Have 31 days");
                       break;
                   case 9:
                       Console.WriteLine("September - Have 30 days");
                       break;
                   case 10:
                       Console.WriteLine("October - Have 31 days");
                       break;
                   case 11:
                       Console.WriteLine("November - Have 30 days");
                       break;
                   case 12:
                       Console.WriteLine("December - Have 31 days");
                       break;
                   default:
                       Console.WriteLine("The month input is valid");
                       break;
               }
           }
           catch (Exception e)
           {
               Console.WriteLine("Input must be a Integer");
           }
        }
    }
}