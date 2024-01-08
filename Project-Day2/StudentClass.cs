using System;

namespace Constructor_Demo
{
    class Student
    {
        readonly int rn;

        string name;
        DateTime dob;
        static string batch;
        int score;
        public Student() { }
        public Student(int rn) {
            this.rn = rn;
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            //Console.WriteLine("Enter Batch");
            //batch = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth");
            dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Score");
            score = Byte.Parse(Console.ReadLine());

        }
        static Student()
        {
            batch = "B001";
        }
        public Student(int rn, string name)
        {
            this.rn = rn;
            this.name = name;
            //Console.WriteLine("Enter Batch");
            //batch = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth");
            dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Score");
            score = Byte.Parse(Console.ReadLine());

        }
        public  Student(int rn , string name , DateTime dob, int score)
        {
            this.rn = rn;
             this.name=name;
            this.dob = dob;
            //this.batch = batch;
            this.score = score;
        }
        public Student(Student obj)
        {
            Console.WriteLine("Enter rn");
            rn = Byte.Parse(Console.ReadLine());


            this.name = obj.name;
            this.dob = obj.dob;
            //this.batch = obj.batch;
            Console.WriteLine("Enter Score");
            score = Byte.Parse(Console.ReadLine());

        }
        public void GetDetails()
        {
            //Console.WriteLine("Enter Rn");
            //rn = Byte.Parse(Console.ReadLine());
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
    }
}
