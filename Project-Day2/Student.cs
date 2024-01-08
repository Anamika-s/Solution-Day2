using System;

namespace Project_Day2
{
    class Student
    {
        int rn;
        string name;
        DateTime dob;
        static string batch;
        const string CollegeName ="ABC";
        
        // How do we assigne value or read value of static variable
        //static string batch = "B001";
        //2 . make  static variable public
        //public static string Batch;
        //3 . Make static method
        int score;
        public void GetDetails()
        {
            Console.WriteLine("Enter Rn");
            rn = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            //Console.WriteLine("Enter Batch");
            //batch = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth");
            dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Score");
            score = Byte.Parse(Console.ReadLine());
        }
        public void DispalyDetails()
        {
            Console.WriteLine($"Rn is {rn}");
            Console.WriteLine($"Name is {name}");
            Console.WriteLine($"Rn is {rn}");
            //Console.WriteLine($"Batch is {batch}");
            Console.WriteLine($"Date of Birth  is {dob}");
            Console.WriteLine($"Scores are {score}");

        }
        public static void BatchDetails()
        {
            batch = "B001";
            //rn = 0;
            Console.WriteLine("Batch is "+ batch);
        }
    }
}
