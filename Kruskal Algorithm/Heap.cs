using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruskal_Algorithm
{
    class Heap
    {
        private int heapBoyut;
        private void BuildHeap(double[] arr)
        {
            heapBoyut = arr.Length - 1;
            for (int i = heapBoyut / 2; i >= 0; i--)
            {
                Heapify(arr, i);
            }
        }

        private void SwapYap(double[] arr, int x, int y)
        {
            double temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        private void Heapify(double[] arr, int index)
        {
            int leftChildIndex = 2 * index;
            int rightChildIndex = 2 * index + 1;
            int largest = index;

            if (leftChildIndex <= heapBoyut && arr[leftChildIndex] > arr[index])
            {
                largest = leftChildIndex;
            }

            if (rightChildIndex <= heapBoyut && arr[rightChildIndex] > arr[largest])
            {
                largest = rightChildIndex;
            }

            if (largest != index)
            {
                SwapYap(arr, index, largest);
                Heapify(arr, largest);
            }
        }
        public void PerformHeapSort(double[] arr)
        {
            BuildHeap(arr);
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                SwapYap(arr, 0, i);
                heapBoyut--;
                Heapify(arr, 0);
            }
        }
    }
}
