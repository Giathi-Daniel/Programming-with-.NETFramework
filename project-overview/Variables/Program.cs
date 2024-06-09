namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int myAge = 22;
            const int x = 22; //AGE CANNOT BE CHANGED
            const int y = 30; //AGE CANNOT BE CHANGED
            char myLetter = 'A';
            bool myBool = true;
            string myText = "Hello World!";

            Console.WriteLine(name);
            Console.WriteLine("You are " + myAge + " years old");
            Console.WriteLine("Your letter is " + myLetter +" " + myBool);
            Console.WriteLine(myText);
            Console.WriteLine(x + y);
        }
    }
}




// Varibles are container for storing data values
// int -> stores intergers (whole numbers)
// double -> stores floating point numbers (19.99, -19.99)
// char -> stores single characters ('A', 'B') sorrounded by single quotes
// string -> stores text, sorounded with double quotes ("Hello World")
// bool -> stores values with teo states: true or false
// variables by uniques names named as -> indentifiers. int minutesPerHour = 60
// --- Naming conventions ---
// Names can contain letters, digits and the underscore(_)
// Names must begin with a letter ofr underscore
// Names should begin with a lowercase letter, and cannot contain whitespace
// Names are case sensitive ("myVar", "myvar")
// Reserved words should not be used.
