using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ArraysLeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch  = new Stopwatch();

            int[] arr = new int[]{1,2,3,4,5,6,7,8,9};

            stopWatch.Start();

            string str = string.Join(",", rotLeft(arr, 5));

            Console.WriteLine(str);

            stopWatch.Stop();
            
            Console.WriteLine("Computational Time: "+stopWatch.ElapsedMilliseconds);

            Console.ReadLine();
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d) {

            Queue<int> queue = new Queue<int>(a);

            for (int i = 0; i<d; i++) {

                int firstElement  = queue.Dequeue();
                queue.Enqueue(firstElement);
            }

            int[] response = new int[queue.Count()];

            for(int i = 0; i< a.Length; i++){
                int variable = queue.Dequeue();
                response[i] = variable;
            }

            return response;

        }
    }
}
