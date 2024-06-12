namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name.: "); //gives ouput
            string userName = Console.ReadLine(); //get user input

            Console.WriteLine("Enter your age.: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + userName + " , you are " + age + " years old");
        }
    }
}
