using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    class Program
    {
        static void Main(string[] args)
        {
            MinHeap minHeap = new MinHeap(10);
            minHeap.Add(3);
            minHeap.Add(2);
            minHeap.Add(15);

            Console.WriteLine("Peek:" + minHeap.Peek());
            Console.WriteLine("Pop:" + minHeap.Pop());
            Console.WriteLine("Peek:" + minHeap.Peek());

            Console.ReadKey();
        }
    }
}
