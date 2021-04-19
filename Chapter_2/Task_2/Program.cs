using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("A", "1Hello");
            sortedList.Add("B", "2Hello");
            sortedList.Add("D", "3Hello");
            sortedList.Add("C", "4Hello");

            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine("\t{0}:\t{1}",sortedList.GetKey(i),sortedList.GetByIndex(i));
            }

            Console.WriteLine("======================");

            for (int i = sortedList.Count-1; i > -1; --i)
            {
                Console.WriteLine("\t{0}:\t{1}", sortedList.GetKey(i), sortedList.GetByIndex(i));
            }
        }
    }
}
