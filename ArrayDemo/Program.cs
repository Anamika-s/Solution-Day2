namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a,b,c,d
            // datatype[] array_name = new type[10]
            int[] num = new int[10];
            for(int i=0;i<10;i++)
            {
                num[i] = int.Parse(Console.ReadLine());

            }
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] += 1;
            //    Console.WriteLine(num[i]);
            //}

            foreach (int i in num)
            {
                //i +=10;
                Console.WriteLine(i);
            }

            int[,] matrix = new int[3, 3];

            //Zagged Array

            // Array of Array 
            int[][] scores = new int[10][];
            scores[0] = new int[2];
            scores[1] = new int[3];






        }
    }
}