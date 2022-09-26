using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.SortArray(new int[] { 5, 3, 1, 8, 0 });
        }
    }

    public class Kata
    {
        public static int[] SortArray(int[] array)
        {
            List<int> list_index = new List<int>();
            List<int> list_odd = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]%2 != 0)
                {
                    list_odd.Add(array[i]);
                    list_index.Add(i);
                }  
            }
            list_odd.Sort();
            for (int i = 0; i < list_index.Count; i++)
            {
                int index = list_index[i];
                array[index] = list_odd[i];
            }
            return array;
        }
    }
}

