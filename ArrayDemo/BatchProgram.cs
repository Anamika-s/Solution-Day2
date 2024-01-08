using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class BatchProgram
    {
        static void Main()
        {
            //Batch batch = new Batch();
            //batch.Get();
            //batch.Display();

            //Batch[] batches= new Batch[10];
            //for (int i = 0; i < 3; i++)
            //{
            //    batches[i] = new Batch();
            //    batches[i].Get();
            //}

            //foreach (Batch batch in batches)
            //{   if(batch!=null)
            //    batch.Display();
            //}

            List<Batch> batches= new List<Batch>();
            string ch = "y";
            while(ch != "y")
            {
                
                Batch batch = new Batch();
                batch.Get();
                batches.Add(batch);
                Console.WriteLine("Add more");
                ch = Console.ReadLine();
            }

            int[] marks = new int[10];
            int[] marks1 = new int[] { 1,2,3,4 };
            // Initialize COllection
            // Collection Initalizer

            //List<Batch> batchList = new List<Batch>()
            //{
            //    new Batch(
            //}




            }

        }
    }

