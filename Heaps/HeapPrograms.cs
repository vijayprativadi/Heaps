using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public class HeapPrograms
    {
        public int FindKthLargest(int[] nums, int k)
        {

            SortedDictionary<int, int> minHeap = new SortedDictionary<int, int>();
            int heapSize = 0;

            foreach (int num in nums)
            {
                if (minHeap.ContainsKey(num))
                    minHeap[num]++;
                else
                    minHeap.Add(num, 1);
                heapSize++;

                if (heapSize > k)
                {
                    var min = minHeap.First();
                    if (min.Value == 1)
                        minHeap.Remove(min.Key);
                    else
                        minHeap[min.Key]--;

                    heapSize--;
                }
            }

            return minHeap.First().Key;
        }
        
        public bool isMinHeap(int[] A, int i)
        {
            //Leaf Node is Heap
            if (2 * i + 2 > A.Length)
            {
                return true;
            }
            
            // recursively check if left child is heap
            bool left = (A[i] <= A[2 * i + 1]) && isMinHeap(A, 2 * i + 1);
            
            bool right = (2 * i + 2 == A.Length) ||
                            (A[i] <= A[2 * i + 2] && isMinHeap(A, 2 * i + 2));

            // return true if both left and right child are heap
            return left && right;
        }
    }
}
