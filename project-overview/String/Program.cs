namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A string contains a collection of characters sorrounded with double quotes

            string greeting = "Hello World!";
            Console.WriteLine(greeting);

            Console.WriteLine("The length of greeting is.: " + greeting.Length);
            Console.WriteLine("Upper case.: " + greeting.ToUpper());
            Console.WriteLine("Lower case.: " + greeting.ToLower());

            Console.WriteLine("============== CONCATENATION ==============");
            string firstName = "Jobs";
            string secondName = "Bradley";
            Console.WriteLine(firstName + " " + secondName);

            Console.WriteLine("============== INTERPOLATION ==============");
            Console.WriteLine("Substitutes values of variables into placeholders in a string");
            string first_name = "John";
            string last_name = "Doe";

            string name = $"My full name is: {first_name} {last_name}";
            Console.WriteLine(name);
        }
    }
}
