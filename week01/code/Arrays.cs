using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        

        // PLAN FOR THE FUCNTION
        // 1. Create a double array named 'multiples' with size 'length'.
        // 2. For each index i from 0 to length - 1:
        //      a. Compute the (i+1)-th multiple of 'number' as: number * (i + 1).
        //      b. Store that value into multiples[i].
        // 3. After the loop, return the 'multiples' array.
        //
        // SOMETHING TO NOTE,: The problem statement guarantees length > 0, but include a "defensive check" right down here below
        // to return an empty array if length is non-positive.

        // Defensive check 
        if (length <= 0)
        {
            return new double[0];
        }

        // Step 1: allocate array
        double[] multiples = new double[length];

        // Step 2: fill array with successive multiples starting at 'number'
        for (int i = 0; i < length; i++)
        {
            // (i + 1) because the first element should be 1 * number (the starting number)
            multiples[i] = number * (i + 1);
        }

        // Step 3: return result
        return multiples;



    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // PLAN FOR THE FUNCTION
        // 1. Handle null or trivial list cases.
        // 2. Normalize amount using modulo: amount = amount % data.Count.
        // 3. Use slicing:
        //      - Take the last 'amount' elements (tail).
        //      - Take the first (n - amount) elements (head).
        // 4. Clear the original list.
        // 5. Add the tail, then add the head back in that order.
        

        if (data == null)
        {
            throw new ArgumentNullException(nameof(data));
        }

        int n = data.Count;
        if (n <= 1) return; 

        int k = amount % n;
        if (k == 0) return; 

        // Slice into two parts
        List<int> tail = data.GetRange(n - k, k);     // last k elements
        List<int> head = data.GetRange(0, n - k);     // first n-k elements

        // Rebuild list in rotated order
        data.Clear();
        data.AddRange(tail);
        data.AddRange(head);



    }
}
