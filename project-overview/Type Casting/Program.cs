namespace Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TYPE CASTING -> is when you assign a value of one data type to another type 

            //1. Implicit type conversion (a smaller type to a larger type) -> done automatically
            int myInt = 9;
            double myDouble = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble); // 9

            //2. Explicit (larger type to a smaller type) -> done manually
            double MyDouble = 9.78;
            int MyInt = (int)MyDouble;

            Console.WriteLine(MyDouble);
            Console.WriteLine(MyInt);

            //3. Inbuild explicit conversion methods (Convert.ToString, Convert.ToInt32, Convert.ToDouble...)
            int my_Int = 10;
            double my_Double = 2.22;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(my_Int));
            Console.WriteLine(Convert.ToDouble(my_Int));
            Console.WriteLine(Convert.ToInt32(my_Double));
            Console.WriteLine(Convert.ToString(myBool));
        }
    }
}
