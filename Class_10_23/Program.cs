using System;

namespace Class_10_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] myStudent = new Student[50];

            myStudent[0] = new Student("Jackson");
            myStudent[1] = new Student("Rachel");
            myStudent[2] = new Student("Sarah");

            myStudent[0].SetClassRank("Junior");
            myStudent[1].SetClassRank("Junior");
            myStudent[2].SetClassRank("Senior");

            Console.WriteLine(myStudent[2]); // Calls the ToString method

            Console.WriteLine(myStudent[0].CompareTo(myStudent[1]));

        }
    }
}
