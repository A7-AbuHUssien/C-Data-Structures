using System;
using System.Collections.Generic;

namespace Min_Heap
{
    internal class Program
    {
        public class MinHeap<T> where T : IComparable<T>
        {
            private List<T> _heap;

            public MinHeap()
            {
                _heap = new List<T>();
            }

            private void HeapifyUp(int index)
            {
                while (index > 0)
                {
                    int parentIndex = (index - 1) / 2;
                    if (_heap[index].CompareTo(_heap[parentIndex]) >= 0) break;
                    (_heap[index], _heap[parentIndex]) = (_heap[parentIndex], _heap[index]);
                    index = parentIndex;
                }
            }

            private void HeapifyDown(int index)
            {
                while (index < _heap.Count)
                {
                    int left = 2 * index + 1;
                    int right = 2 * index + 2;
                    int smallest = index;

                    if (left < _heap.Count && _heap[smallest].CompareTo(_heap[left]) > 0)
                        smallest = left;

                    if (right < _heap.Count && _heap[smallest].CompareTo(_heap[right]) > 0)
                        smallest = right;

                    if (smallest == index) break;

                    (_heap[index], _heap[smallest]) = (_heap[smallest], _heap[index]);
                    index = smallest;
                }
            }

            public void Insert(T item)
            {
                _heap.Add(item);
                HeapifyUp(_heap.Count - 1);
            }

            public T Peek()
            {
                if (_heap.Count == 0)
                    throw new InvalidOperationException("Heap is empty");
                return _heap[0];
            }

            public T ExtractMin()
            {
                if (_heap.Count == 0)
                    throw new InvalidOperationException("Heap is empty");

                T min = _heap[0];
                _heap[0] = _heap[_heap.Count - 1];
                _heap.RemoveAt(_heap.Count - 1);
                HeapifyDown(0);
                return min;
            }

            public void Display()
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                foreach (T item in _heap)
                    Console.WriteLine(item + " ");
                Console.ResetColor();
            }
        }

        static void Main(string[] args)
        {
            MinHeap<int> heap = new MinHeap<int>();
            heap.Insert(10);
            heap.Insert(5);
            heap.Insert(9);
            heap.Insert(8);
            heap.Insert(7);
            heap.Insert(4);
            heap.Insert(6);
            heap.Insert(3);
            heap.Insert(2);
            heap.Insert(1);

            heap.Display();

            Console.WriteLine("Peek: " + heap.Peek());
            Console.WriteLine("ExtractMin: " + heap.ExtractMin());
            Console.WriteLine("After ExtractMin:");
            heap.Display();
        }
    }
}
