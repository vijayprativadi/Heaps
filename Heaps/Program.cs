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

            Console.WriteLine("Min Heap:");
            Console.WriteLine("Peek:" + minHeap.Peek());
            Console.WriteLine("Pop:" + minHeap.Pop());
            Console.WriteLine("Peek:" + minHeap.Peek());

            MaxHeap maxHeap = new MaxHeap(10);
            maxHeap.Add(3);
            maxHeap.Add(2);
            maxHeap.Add(15);

            Console.WriteLine("Max Heap:");
            Console.WriteLine("Peek:" + maxHeap.Peek());
            Console.WriteLine("Pop:" + maxHeap.Pop());
            Console.WriteLine("Peek:" + maxHeap.Peek());

            HeapPrograms heapPrograms = new HeapPrograms();
            int[] kthLargestNums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Find Kth Largest " + heapPrograms.FindKthLargest(kthLargestNums, 2));
            Console.WriteLine("Find Kth Smallest " + heapPrograms.FindKthSmallest(kthLargestNums, 2));

            Console.ReadKey();
        }
    }
}
