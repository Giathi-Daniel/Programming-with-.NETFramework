namespace Control_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // If, ternary
           int age = 20;
           if (age < 18)
            {
                Console.WriteLine("You are not yet eligible to have an Identification Number");
            } else
            {
                Console.WriteLine("You are eligible for an Identification Number");
            }

           // Ternary
           string result = (age < 18) ? "You are not yet eligible to have Driving License" : "You are eligible for a Driving License";
           Console.WriteLine(result);

            // SWITCH
            int day = 7;

            switch (day)
            {
                case 0:
                    Console.WriteLine("Today is Sunday");
                    break;
                case 1:
                    Console.WriteLine("Today is Monday");
                    break;
                case 2:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Today is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Today is Friday");
                    break;
                case 6:
                    Console.WriteLine("Today is Saturday");
                    break;
                default:
                    Console.WriteLine("Enter valid date Number from (0 - 6)");
                    break;

            }
            // FOR LOOP
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            // FOR EACH
            string[] bikes = { "Yamaha", "BMW", "FireBlade", "Gixxer" };
            foreach(string i in bikes)
            {
                Console.WriteLine(i);
            }
        }
    }
}
