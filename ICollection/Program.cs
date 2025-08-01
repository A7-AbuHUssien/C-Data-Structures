﻿/*
     • Count: Gets the number of elements contained in the collection.
     • IsReadOnly: Gets a value indicating whether the collection is read-only.
     • Add, Remove, Clear: Methods to modify the collection.
     • Contains Method: Checks if the collection contains a specific item.
*/
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public class SimpleCollection<T> : ICollection<T>
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;
        public bool IsReadOnly => false;
        public void Add(T item)
        {
            items.Add(item);
        }
        public void Clear()
        {
            items.Clear();
        }
        public bool Contains(T item)
        {
            return items.Contains(item);
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            items.CopyTo(array, arrayIndex);
        }
        public bool Remove(T item)
        {
            return items.Remove(item);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    static void Main(string[] args)
    {
        SimpleCollection<string> shoppingCart = new SimpleCollection<string>();
        shoppingCart.Add("Apple");
        shoppingCart.Add("Banana");
        shoppingCart.Add("Carrot");


        Console.WriteLine($"Items in cart: {shoppingCart.Count}");

        if (shoppingCart.Contains("Banana"))
        {
            shoppingCart.Remove("Banana");
            Console.WriteLine("Banana removed from the cart.");
        }


        Console.WriteLine("Final items in the cart:");
        foreach (var item in shoppingCart)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }
}
