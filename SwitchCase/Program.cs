namespace SwitchCase
{
    class SwitchCase
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a number");
            string a = Console.ReadLine();
            int s = Convert.ToInt32(a);
            // using switch case to display days with number inputs 
            switch (s)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}