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

        // create new array and temp val for values in array
        double[] multiples = new double[length];
        double tempVal = 0;
        // loop to add number to tempVal in order to calculate the multiple and add to multiples array
        for (int i = 0; i < length; i++)
        {
            tempVal += number;
            multiples[i] = tempVal;
        }

        // return array filled with quantity of multiples requested
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static List<int> RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //create list to sort data list
        List<int> sortedData;

        sortedData = data.GetRange(data.Count - amount, amount);
        Console.WriteLine("Part One");
        Console.WriteLine(string.Join(", ", sortedData));
        sortedData.AddRange(data.GetRange(0, data.Count - amount));
        Console.WriteLine("Part Two");
        Console.WriteLine(string.Join(", ", sortedData));
        data = sortedData;
        Console.WriteLine("Data End");
        Console.WriteLine(string.Join(", ", data));

        return sortedData;
    }
}
