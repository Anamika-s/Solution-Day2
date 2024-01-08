using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class Batch
    {
        string name;
        int strength;
        public void Get()
        {
            Console.WriteLine("ENter NAme");
            name = Console.ReadLine();
            Console.WriteLine("ENter strength");
            strength = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine(name + " " + strength);
        }
    }
}