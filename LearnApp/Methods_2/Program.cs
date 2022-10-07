using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2
{

    internal class Program
    {
        static void Resize(ref int[] arr, uint newSize)
        {
            int[] newArray = new int[newSize];

            for (int i = 0; i < arr.Length && i < newArray.Length; i++)
                newArray[i] = arr[i];

            arr = newArray;
        }
        static void addFirst(ref int[] arr, int value)
        {
            Insert(ref arr, value, 0);
        }
        static void addLast(ref int[] arr, int value)
        {
            Insert(ref arr, value, (uint)arr.Length);
        }
        static void Insert(ref int[] arr, int value, uint index)
        {
            int[] newArray = new int[arr.Length + 1];
            newArray[index] = value;

            for (int i = 0; i < index; i++)
                newArray[i] = arr[i];
            
            for (uint i = index; i < arr.Length; i++)
                newArray[i+1] = arr[i];

            arr = newArray;
        }
        static void RemoveAt(ref int[] arr, uint index)
        {
            int[] newArray = new int[arr.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = arr[i];

            for (uint i = index + 1; i < arr.Length; i++)
                newArray[i-1] = arr[i];

            arr = newArray;

        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 45, 23, 14 };
            //RemoveAt(ref myArray, 2);
            //Array.Resize(ref myArray, 10);

            //addFirst(ref myArray, 10);
            //addLast(ref myArray, 15);
            //Insert(ref myArray, 56, 2);
            Resize(ref myArray, 10);
        }
    }
}
