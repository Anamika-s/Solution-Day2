using System;
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

            Batch[] batches= new Batch[10];
            for (int i = 0; i < 3; i++)
            {
                batches[i] = new Batch();
                batches[i].Get();
            }

            foreach (Batch batch in batches)
            {   if(batch!=null)
                batch.Display();
            }

            }

        }
    }

