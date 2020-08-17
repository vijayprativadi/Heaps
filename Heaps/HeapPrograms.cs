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
    }

}
