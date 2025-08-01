﻿/*
• Index-based access: IList provides the ability to access, modify, or remove items based on their index in the collection.
• Insert and RemoveAt: Add or remove elements at a specified index, adjusting the collection accordingly.
• IndexOf: Find the index of a specific element in the collection.
• Count and IsReadOnly properties: Similar to ICollection,these properties provide information about the size of the collection and whether it is read-only.
• Add, Insert, Remove, and RemoveAt methods: Beyond the capabilities inherited from ICollection, IList allowsfor inserting and removing items at specified indices.
 */
using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        SimpleList<string> myList = new SimpleList<string>();
        myList.Add("First");
        myList.Add("Second");
        myList.Insert(1, "Inserted");


        Console.WriteLine("List after adding and inserting:");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }


        myList.RemoveAt(1); // Removes "Inserted"
        myList[0] = "Updated First"; // Update the first item


        Console.WriteLine("\nList after removing and updating:");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }
    }
    public class SimpleList<T> : IList<T>
    {
        private List<T> _items = new List<T>();


        public T this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }
        public int Count => _items.Count;
        public bool IsReadOnly => false;
        public void Add(T item) => _items.Add(item);
        public void Clear() => _items.Clear();
        public bool Contains(T item) => _items.Contains(item);
        public void CopyTo(T[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);
        public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();
        public int IndexOf(T item) => _items.IndexOf(item);
        public void Insert(int index, T item) => _items.Insert(index, item);
        public bool Remove(T item) => _items.Remove(item);
        public void RemoveAt(int index) => _items.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => _items.GetEnumerator();
    }

}