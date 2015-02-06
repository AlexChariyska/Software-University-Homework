using System;


namespace Problem7_Strings_Objects
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            //Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables. Declare a third string variable and initialize it with the value of the object variable 

            string a = "Hello";
            string b = "World !";
            object result = a + " " + b;
            string finalResult = (string)result;
            Console.WriteLine(finalResult);
        }
    }
}
