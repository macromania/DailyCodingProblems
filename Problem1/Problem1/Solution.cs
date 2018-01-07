using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public class Solution
    {
        public int[] Run(int[] input)
        {
            // Find Middle
            var middle = FindMiddle(input);

            // Get the second half
            var secondHalfReversed = GetSecondHalfReversed(input);
            var interLeaved = new int[input.Length];
            interLeaved[0] = input[0];
            interLeaved[input.Length - 1] = input[middle];

            // Interleave the first half
            for (var i = 1; i < middle; i++)
            {
                var current = input[i];
                var newIndexForCurrent = i + i;
                if (newIndexForCurrent < input.Length)
                {
                    interLeaved[newIndexForCurrent] = current;
                }
            }

            var currentSecondHalfIndex = 0;

            for (var i = 0; i < interLeaved.Length; i++)
            {
                if (interLeaved[i] == 0 && currentSecondHalfIndex < secondHalfReversed.Length)
                {
                    interLeaved[i] = secondHalfReversed[currentSecondHalfIndex];
                    currentSecondHalfIndex++;
                }
            }
            

            return interLeaved;
        }

        public int FindMiddle(int[] input)
        {
            return input.Length / 2;
            //var middle = input.Length / 2;
            //return (input.Length % 2 == 0) ? middle - 1 : middle;
        }

        public int[] GetSecondHalfReversed(int[] input)
        {
            var middle = FindMiddle(input);
            var secondHalf = new List<int>();

            for (var i = middle + 1; i < input.Length; i++)
            {
                secondHalf.Add(input[i]);
            }

            secondHalf.Reverse();

            return secondHalf.ToArray();
        }
    }
}
