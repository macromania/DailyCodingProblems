using System;

namespace Problem1
{
    class Program
    {
        /*
         * This problem was asked by Google.
         * Given a stack of N elements, interleave the first half of the stack with the second half reversed using only one other queue.
         * This should be done in-place.
         * Recall that you can only push or pop from a stack, and enqueue or dequeue from a queue.
         * For example, if the stack is [1, 2, 3, 4, 5], it should become [1, 5, 2, 4, 3]. If the stack is [1, 2, 3, 4], it should become [1, 4, 2, 3].
         * Hint: Try working backwords from the end state.
         * If you liked this problem, feel free to forward it along! If you got here from a forwarded email, you can sign up for Daily Coding Problem at dailycodingproblem.com.
         *
         */
        static void Main(string[] args)
        {
            var set1 = new[] { 1, 2, 3, 4, 5 };
            var set2 = new[] { 1, 2, 3, 4 };

            var solution = new Solution();

            Print("Running solution for input:", set1);
            var result = solution.Run(set1);
            Print("Solution:", result);

            Print("Running solution for input:", set2);
            result = solution.Run(set2);
            Print("Solution:", result);
        }

        static void Print(string message, int[] input)
        {
            Console.Write(message);
            foreach (var i in input)
            {
                Console.Write($"{i},");
            }
            Console.WriteLine();
        }
    }
}
