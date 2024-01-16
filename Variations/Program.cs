using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Variations
{
    internal class Program
    {
        

        static void Print(int[] array)
        {
            Console.WriteLine(string.Join(" | ", array));
        }
        static void Variations(int[] array, int index, int start, int end)
        {
            if (index >= array.Length)
            {
                Print(array);
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    array[index] = i;
                    Variations(array, index + 1, i, end);
                }
            }
        }
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Enter array length: ");
                int length = int.Parse(Console.ReadLine());
                Console.Write("Enter starting index ( 0 is suggested): ");
                int index = int.Parse(Console.ReadLine());
                Console.Write("Enter number 'start at': ");
                int start = int.Parse(Console.ReadLine());
                Console.Write("Enter number 'ends at': ");
                int end = int.Parse(Console.ReadLine());
                int[] array = new int[length];
                Variations(array, index, start, end);
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
