// See https://aka.ms/new-console-template for more information

// .dll .exe
using System;

namespace ConsoleApp1
{
    class Program : Program2
    { // public means that this method is accessible from another classes
        // classes cannot go into Main block
        public void getData() // void means that this method does not return anything
        {
            Console.WriteLine("I'm inside the method.");
        }

        static void Main(string[] args)
        {
            // to call getData() method we have to create an object
            // based on Program class
            Program p = new Program();
            p.getData();
            p.SetData();

            // int (whole numbers) and String are static data types
            Console.WriteLine("Hello World");
            int a = 10;
            double c = 11.22;
            Console.WriteLine("Number is " + a);
            string name = "Raf";
            Console.WriteLine("Name is " + name);
            string name2 = "Betty";
            Console.WriteLine($"2nd name is {name2}");

            // var is dynamic data type - use when you don't know what data type you are dealing with
            var age = 30;
            var age2 = "30";
            Console.WriteLine($"age is {age}");
            Console.WriteLine($"age2 is {age2}");
            // age = "hello" not allowed
            // dynamic keyword for dynamic data type
            dynamic height = 13.2; // if dynamic type you can change the value of height to different data types
            Console.WriteLine($"Value of height as double {height}");
            height = "hello";
            Console.WriteLine($"Value of height as String {height}");
        }
    }
}