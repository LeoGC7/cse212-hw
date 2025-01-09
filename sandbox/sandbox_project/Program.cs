using System;
using System.Runtime.CompilerServices;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        var numbers = new List<int> {1,2,3,4,5};

        foreach (var item in numbers) {
            Console.WriteLine(item);
        }

        for (var index = 0; index < numbers.Count; index++) {
            Console.WriteLine(numbers[index]);
        }
    }
}