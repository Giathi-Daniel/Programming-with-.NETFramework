namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) A method is a block of code which only runs when called
            // static -> This method belongs to the Program Class and not its object
            // void -> This method deos not have a return value
            // Naming convention -> Use Camel case
            
            static void MyMethod()
            {
                Console.WriteLine("I just got executed!");
            }

            MyMethod();
            MyMethod();
            MyMethod();

            // 2) Parameters and Arguements
            static void MyMainMethod(string firstName) // parameter + default value
            {
                Console.WriteLine(firstName + " Kenyan");
            }

            MyMainMethod("\n Jobs"); // argument
            MyMainMethod("Stephen");


            // Return values (chenge void to int or double)
            static int ReturnMethod(int x, int y)
            {
                return x * y;
            }

            int z = ReturnMethod(2, 13);
            Console.WriteLine(z);


            // 3) Method OverLoading -> multiple methods can have the same name but with different functions
            static int PlusMethod(int x, int y)
            {
                return x + y;
            }

            static double PlusMethod(double x, double y)
            {
                return x + y;
            }

            // Calling the integer version of PlusMethod
            int myResult = PlusMethod(3, 5);

            // Calling the double version of PlusMethod
            double myResultDouble = PlusMethod(2.3, 5.3);

            // Outputting the results
            Console.WriteLine(myResult);         // Output: 8
            Console.WriteLine(myResultDouble);   // Output: 7.6
        }
    }
}
