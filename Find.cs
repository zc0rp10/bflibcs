using System;

namespace bflibcs
{
    public class Find
    {
        public static int LargestOfThree(int a, int b, int c)
        {
            int large;
          
            if (a > b && a > c)
                large = a;
            else if (b > a && b > c)
                large = b;
            else
                large = c;

            return large;
        }
    }


}
