using System;
using System.Collections.Generic;

public class MaxHeap
{
    private List<int> heap = new List<int>();

    public void Insert(int value)
    {
        heap.Add(value);
        HeapifyUp(heap.Count - 1);
    }

    private void HeapifyUp(int index)
    {
        while (index > 0)
        {
            int parentIndex = (index - 1) / 2;
            if (heap[index] <= heap[parentIndex]) break;
            (heap[index], heap[parentIndex]) = (heap[parentIndex], heap[index]);
            index = parentIndex;
        }
    }

    public int Peek()
    {
        if (heap.Count == 0)
            throw new InvalidOperationException("Heap is empty.");
        return heap[0];
    }

    public int ExtractMax()
    {
        if (heap.Count == 0)
            throw new InvalidOperationException("Heap is empty.");

        int maxValue = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);
        HeapifyDown(0);
        return maxValue;
    }

    private void HeapifyDown(int index)
    {
        while (index < heap.Count)
        {
            int leftChildIndex = 2 * index + 1;
            int rightChildIndex = 2 * index + 2;
            int largestIndex = index;

            if (leftChildIndex < heap.Count && heap[leftChildIndex] > heap[largestIndex])
                largestIndex = leftChildIndex;

            if (rightChildIndex < heap.Count && heap[rightChildIndex] > heap[largestIndex])
                largestIndex = rightChildIndex;

            if (largestIndex == index) break;

            (heap[index], heap[largestIndex]) = (heap[largestIndex], heap[index]);
            index = largestIndex;
        }
    }

    public void DisplayHeap()
    {
        Console.WriteLine("\nHeap Elements: ");
        foreach (int value in heap)
            Console.Write(value + " ");
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        MaxHeap maxHeap = new MaxHeap();

        Console.WriteLine("Inserting elements into the Max-Heap...\n");
        maxHeap.Insert(10);
        maxHeap.Insert(4);
        maxHeap.Insert(15);
        maxHeap.Insert(2);
        maxHeap.Insert(8);

        maxHeap.DisplayHeap();

        Console.WriteLine("\nPeek Maximum Element: Maximum Element is: " + maxHeap.Peek());

        maxHeap.DisplayHeap();

        Console.WriteLine("\nExtracting elements from the Max-Heap:");
        Console.WriteLine("Extracted Maximum: " + maxHeap.ExtractMax());
        maxHeap.DisplayHeap();

        Console.WriteLine("\nExtracted Maximum: " + maxHeap.ExtractMax());
        maxHeap.DisplayHeap();

        Console.ReadKey();
    }
}
