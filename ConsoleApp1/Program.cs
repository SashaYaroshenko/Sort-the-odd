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
            
            List<int> list_odd = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]%2 != 0)
                {
                    list_odd.Add(array[i]);
                    array[i] = -999;
                }  
            }
            list_odd.Sort();
            for(int i = 0; i < array.Length; i++)
            {
                for (int l = 0; l < list_odd.Count; l++)
                {
                    if (array[i] == -999)
                    {
                        array[i] = list_odd[l];
                        i++;
                    }
                    else if (array[i] == array[array.Length-1])
                    {
                        break;
                    }
                    else
                    {
                        i++;
                        l--;
                    }
                }
            }
            return array;
        }
    }
}
