using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BubbleSort_DanielMinty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] ints = new int[rand.Next(10, 31)];

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rand.Next(1, 100);
            }

            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            BubbleSort(ints);

            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();

        }

        public static void BubbleSort(int[] array)
        {
            bool swapOccured = true;

            while (swapOccured)
            {
                swapOccured = false;

                for (int currentIndex = 0; currentIndex < array.Length - 1; currentIndex++)
                {
                    if (array[currentIndex] > array[currentIndex + 1])
                    {
                        int temp = array[currentIndex + 1];

                        array[currentIndex + 1] = array[currentIndex];

                        array[currentIndex] = temp;

                        swapOccured = true;

                    }

                }

            }

        }

    }
}
