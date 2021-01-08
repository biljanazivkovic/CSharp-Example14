using System;

namespace ex14
{
    class Program
    {
        //private string model = "Mustang";

        static void Main(string[] args)
        {
            Car Ford = new Car();
            Console.WriteLine(Ford.model);
            //'Car.model' is inaccessible due to its protection level
        }
    }
}
