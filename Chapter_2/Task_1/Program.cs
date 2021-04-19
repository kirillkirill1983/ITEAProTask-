using System;
using System.Collections;
/// <summary>
/// домашнее задание 1 и 2 обеденение 
/// </summary>
namespace Task_1
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            for (int i = 0; i < 20; i++)
            {
                array[i] = i;
            }
            MyList<int> myList = new MyList<int>(array);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write("{0} ", myList[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("foreach ");
            foreach (var item in myList)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("\n");
            myList.Add(23);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write("{0} ", myList[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Метод расширения");
            foreach (var item in myList.GetArray())
            {
                Console.Write("{0} ", item.ToString());
            }
            Console.ReadKey();

            myList.Clear();
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i]);
            }
            Console.WriteLine(myList.Contains(5).ToString());

        }
        public static T[] GetArray<T>(this MyList<T> List)
        {
            T[] newarray = new T[List.Count];
            for (int i = 0; i < List.Count; i++)
            {
                newarray[i] = List[i];
            }
            return newarray;
        }
    }
    interface IMylist<T>
    {
        T this[int index] { get; }
        int Count { get; }
        void Add(T a);
        bool Contains(T item);
        void Clear();

    }

    internal class MyList<T> : IMylist<T>, IEnumerable
    {

        private T[] array;
        public MyList(T[] array)
        {
            this.array = array;
        }
        public T this[int index] { get { return array[index]; } }

        public int Count { get { return array.Length; } }

        public void Clear()
        {
            array = new T[0] { };
        }

        public bool Contains(T item)
        {
            int resukt = Array.BinarySearch(array, item);
            if (resukt != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Add(T a)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = a;
        }

        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }
    }
}
