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

            //Create an int array with a random size from 10 to 30
            int[] ints = new int[rand.Next(10, 31)];

            //Set each element to a random number from 1 to 99
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rand.Next(1, 100);
            }

            //Display the array on one line.
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }

            //Sort the array
            BubbleSort(ints);

            //Display the sorted array on a new line.
            Console.WriteLine();
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }

            //Keep the window open.
            Console.ReadLine();

        }

        public static void BubbleSort(int[] array)
        {
            //Stores whether a swap occured on the last pass.
            //True: The array is still being sorted, and another pass should be performed.
            //False: The array is done being sorted, no more passes should be performed.
            //Default True because we need to perform at least one pass to determine if the array is sorted.
            bool swapOccured = true;

            //As long as the array is unsorted, keep making passes.
            while (swapOccured)
            {
                //On each new pass, set swapOccured to false to track if a swap occurs on this pass.
                swapOccured = false;

                //For each element, excluding the last element in the array,
                for (int currentIndex = 0; currentIndex < array.Length - 1; currentIndex++)
                {
                    //Compare the current element to the next element in the array.
                    //If the current element is larger than the next element, then they are out of order and need to be swapped.
                    if (array[currentIndex] > array[currentIndex + 1])
                    {
                        //To swap the current and next element,
                        //temporarily store the old next element,
                        int temp = array[currentIndex + 1];
                        //replace the old next element with the old current element that's now the new next element,
                        array[currentIndex + 1] = array[currentIndex];
                        //replace the old current element with the stored old next element that's now the new current element.
                        array[currentIndex] = temp;
                        //Set swapOccured to true because a swap occured.
                        swapOccured = true;

                    }
                    //If the current element is NOT larger than the next element, then they are in order and don't need to be swapped.
                    //Move to the next element.
                }
                //Pass completed.
            }
            //No swap occured on the last pass, the array is sorted.
        }

    }
}
