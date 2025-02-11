using System;
using System.Runtime.CompilerServices;

public static class SetOperations {
    public static HashSet<int> FindIntersection(HashSet<int> set1, HashSet<int> set2) {

        HashSet<int> result = new HashSet<int>();

        foreach (int num in set1) {
            if (set2.Contains(num)) { // I iterate through set1 and compare it's numbers with set 2, if they have numbers in common the number will be added to the result
                result.Add(num);
            }
        }

        return result; // Big O notation is O(n+n) = O(2n) which is O(n), n being the size of the set
    }

    //Find Union Function
    public static HashSet<int> FindUnion(HashSet<int> set1, HashSet<int> set2) { //Here I create a function that returns a HashSet and receive two HashSets as parameters
        
        HashSet<int> result = new HashSet<int>();
        
        foreach(int num in set1) { //First I iterate through set1 and add all the numbers to the result
            result.Add(num);
        } 

        foreach(int num in set2) { //Then I iterate through set2 and aslo add all the numbers to the result
            result.Add(num);
        }

        return result; //Since result is a HashSet, duplicated numbers won't be added again, resulting in the union of the numbers that set1 and set2 has in commmon
                       // Big O notation is O(n+n) = O(2n) which is O(n), n being the size of the set
    }


    // Test cases
    public static void Main() {
        // Test cases for FindIntersection
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6 };

        HashSet<int> intersection = FindIntersection(set1, set2);
        Console.WriteLine(string.Join(" ", intersection)); // Expected: 3, 4

        HashSet<int> set3 = new HashSet<int> { 1, 2 };
        HashSet<int> set4 = new HashSet<int> { 3, 4 };

        HashSet<int> intersection2 = FindIntersection(set3, set4);
        Console.WriteLine(string.Join(" ", intersection2)); // Expected: (empty)

        HashSet<int> set5 = new HashSet<int> { 1 };
        HashSet<int> set6 = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7 };

        HashSet<int> intersection3 = FindIntersection(set5, set6);
        Console.WriteLine(string.Join(" ", intersection3)); // Expected: 1

        // Test cases for FindUnion
        HashSet<int> union = FindUnion(set1, set2);
        Console.WriteLine(string.Join(" ", union)); // Expected: 1, 2, 3, 4, 5, 6

        HashSet<int> set7 = new HashSet<int> {};
        HashSet<int> set8 = new HashSet<int> { 6, 7, 8 };

        HashSet<int> union2 = FindUnion(set7, set8);
        Console.WriteLine(string.Join(" ", union2)); // Expected: 6, 7, 8

        HashSet<int> set9 = new HashSet<int> {};
        HashSet<int> set10 = new HashSet<int> {};

        HashSet<int> union3 = FindUnion(set9, set10);
        Console.WriteLine(string.Join(" ", union3)); // Expected: (empty)
    }
}

