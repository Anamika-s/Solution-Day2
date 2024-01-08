namespace Project_Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToString("dd MMM")); 
            // Aug 04);
            if(DateTime.Now.ToString("dd MMM").Equals("08 Jan"))
                Console.WriteLine("Y");
            else
                Console.WriteLine("N");
            //Student.Batch = "B001";
            //Console.WriteLine("Batch is " + Student.Batch);
            //Student student = new Student();  // 1. It calls constructor (def) 
            // // 2. new keyword will allocate memory in heap
            // student.GetDetails();
            // student.DispalyDetails();
            //Student.BatchDetails();
            //Student student1 = new Student();  // 1. It calls constructor (def) 
            //// 2. new keyword will allocate memory in heap
            //student1.GetDetails();
            //student1.DispalyDetails();

            //Student student2 = new Student();  // 1. It calls constructor (def) 
            //// 2. new keyword will allocate memory in heap
            //student2.GetDetails();
            //student2.DispalyDetails();

            //Constructor_Demo.Student student1 = new Constructor_Demo.Student();
            //student1.GetDetails();
            //student1.DispalyDetails();

            //// this will invoke para constr
            //Constructor_Demo.Student student2 = new Constructor_Demo.Student(1);
            //student2.DispalyDetails();

            //// this will invoke para constr
            //Constructor_Demo.Student student3 = new Constructor_Demo.Student(rn: 2, name: "Deepak");
            //student3.DispalyDetails();

            Constructor_Demo.Student student4 = new Constructor_Demo.Student(
                score: 90, dob: DateTime.Parse("12/12/2004"), rn: 10, name: "Gagan");
            student4.DispalyDetails();

            // this will invoke copy const
            Constructor_Demo.Student student5 = new Constructor_Demo.Student(student4);

        } 

    }
}