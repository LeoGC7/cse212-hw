


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

        /// First of all, I need a list that can store these elements. It can be an array cause the "lenght" will vary.
        /// To get a multiple of a number, you multiply that "number" by another. e.g (7*4 = 28, 28 is a multiple of 7)
        /// I must do a loop that can multiple the number chosen, starting with 1 and increasing till it reach to the
        /// "lenght" specified. The "lenght" will be the same as the last multiplier. e.g (lenght = 4, it must get 4
        /// multiples. Multiply it by 1,2,3 and 4)

        List<double> multiples = new();

        for (int i = 1; i <= length; i++) {
            double element = number * i;

            multiples.Add(element);
        }

        return multiples.ToArray();
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

        /// First I need to get how many elements the list has, so I can calculate the last elements which will
        /// be defined by the "amount" variable. If I want to rotate the last 4 elements, the amount will be 4.
        /// Then I need to remove the last elements defined by the "amount" variable from the list and insert them
        /// in the beggining of the list using Remove, and Insert Range functions.

        int c = data.Count;

        List<int> lastElements = data.GetRange(c - amount, amount);

        data.RemoveRange(c - amount, amount);

        data.InsertRange(0, lastElements);
    }
}
