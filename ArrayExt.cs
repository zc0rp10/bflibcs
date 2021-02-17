using System;
using System.Collections.Generic;
using System.Text;

namespace bflibcs
{
    /// <summary>
    /// Represents enhanced utility functions for manipulating arrays.
    /// </summary>



    class ArrayExt
    {
        private static void PushLeft(int[] arr, int step)
        {
            // Before: [1][2][3][4][5]. After: [3][4][5][4][5].
            for (int i = 0; i < arr.Length - step; i++)
            {
                arr[i] = arr[i + step];
            }
        }

        private static void PushRight(int[] arr, int step)
        {
            // Before: [1][2][3][4][5]. After: [1][2][1][2][3].
            for (int i = arr.Length - 1; i >= 0 + step; i--)
            {
                arr[i] = arr[i - step];
            }

            // Snippets
            Console.ReadKey();


        }


    }
}
