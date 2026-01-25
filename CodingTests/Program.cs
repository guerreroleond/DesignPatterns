// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using CodingTests;
using CodingTests.Algorithms;
using CodingTests.Exercises.Easy;
using CodingTests.Models;
using CodingTests.Recursive;
using CodingTests.Sorting;
using CodingTests.Sorting.Recursive;

// Console.WriteLine("Hello, Fibonacci!");

// var fib = new Fibonacci();

// var nTh = 16;

// Console.WriteLine($"Search the {nTh}-th number");
// var result = fib.BottFib(nTh);

// Console.WriteLine($"The result is {result}");

// Console.ReadKey();


// Console.WriteLine("Hello, MinCoins");

// var minCoins = new MinCoins();

// var m = 13;

// Console.WriteLine($"Search the MinCoins for {m}");

// var coins = new List<int>{1, 4, 5 };

// var result = minCoins.Coins(13, coins);

// Console.WriteLine($"The result is {result}");

#region Binary Search
//
// var numbers = new List<int>{ 12, 22, 37, 48, 53, 66, 74, 83, 90 };
// var wantedNumber = 74;
//
// Console.WriteLine($"From the following numbers:");
// foreach(var num in numbers)
// {
//     Console.WriteLine();
//     Console.Write($" {num} ");
// }
// Console.WriteLine();
// Console.WriteLine($"Wanted number: {wantedNumber}");
//
// var result = BinarySearch.SearchNumberAlt(numbers, wantedNumber);
//
// Console.WriteLine($" Result -> [{result}]");

#endregion Binary Search

#region Find First and Last

// var numbers = new List<int> { 5,7,7,8,8,10,11,12,13,14,15,16,17,18};
// var target = 8;
// var result = new List<int>();

// BinarySearch.FindFirstAndLast(numbers, target, result, 0);

// if(result.Count >= 2)
// {
//     Console.WriteLine($"Result: ");
//     foreach(var index in result)
//     {
//         Console.WriteLine($"{index}");
//     }
// }

#endregion Find First and Last

#region Selection Sort

/* var unorderedList = new List<int> { 5, 3, 6, 2, 10 };

Console.WriteLine("Sort the following list:");
Console.WriteLine();

foreach(var num in unorderedList)
{
    Console.Write($" {num} ");
}

var orderedList = SelectionSort.Sort(unorderedList);

Console.WriteLine();
Console.WriteLine("Ordered list:");
Console.WriteLine();

foreach(var num in orderedList)
{
    Console.Write($" {num} ");
} */

#endregion Selection Sort

#region Factorial

// var number = 4;
// Console.WriteLine($"Calculate factorial of {number}");

// var result = Factorial.Fact(number);

// Console.WriteLine($"Result: {result}");
 
 #endregion Factorial

#region Recursive Sum

// var numbers = new List<int>{ 2, 4, 6 };

// Console.WriteLine($"Sum the following numbers resursively:");
// Console.WriteLine();

// foreach(var num in numbers)
//     Console.Write($" {num} ");

// var result = RecSum.Sum(numbers);

// Console.WriteLine();
// Console.WriteLine($"Result = {result}");

#endregion Recursive Sum

#region Recursive Counter

// var numbers = new List<int>{ 2, 4, 6 };

// Console.WriteLine($"Count the number of elements resursively:");
// Console.WriteLine();

// foreach(var num in numbers)
//     Console.Write($" {num} ");

// var result = RecCounter.CountItems(numbers);

// Console.WriteLine();
// Console.WriteLine($"Result = {result}");

#endregion Recursive Counter

#region Recursive Max

// var numbers = new List<int>{ 2, 4, 6 };

// Console.WriteLine($"Get the max number of elements resursively:");
// Console.WriteLine();

// foreach(var num in numbers)
//     Console.Write($" {num} ");

// var result = RecCounter.Max(numbers);

// Console.WriteLine();
// Console.WriteLine($"Result = {result}");

#endregion Recursive Max

#region Recursive Binary Search

// var numbers = new List<int>{ 12, 22, 37, 48, 53, 66, 74, 83, 90, 99, 102 };
// var wantedNumber = 102;
//
// Console.WriteLine($"From the following numbers:");
// for(var i = 0; i < numbers.Count; i++)
// {
//     Console.WriteLine();
//     Console.Write($" {numbers[i]} [{i}] ");
// }
// Console.WriteLine();
// Console.WriteLine($"Wanted number: {wantedNumber}");
//
// var result = RecBinarySearch.Search(numbers, wantedNumber, 0);
//
// Console.WriteLine($" Result -> [{result}]");

#endregion Recursive Binary Search

#region Quicksort

// var unorderedList = new List<int> { 5, 3, 6, 2, 10 };
//
// Console.WriteLine("Sort the following list:");
// Console.WriteLine();
//
// foreach(var num in unorderedList)
// {
//     Console.Write($" {num} ");
// }
//
// var orderedList = Quicksort.Sort(unorderedList);
//
// Console.WriteLine();
// Console.WriteLine("Ordered list:");
// Console.WriteLine();
//
// foreach(var num in orderedList)
// {
//     Console.Write($" {num} ");
// } 

#endregion Quicksort

#region Exc Easy - Two Sum

// var nums = new int[] {-1,-2,-3,-4,-5};
// const int target = -8;
// Console.WriteLine("Given the following array:");
// Console.WriteLine();
//
// foreach (var item in nums)
// {
//     Console.WriteLine($" {item} ");
// }
// Console.WriteLine();
// Console.WriteLine($" and an integer target {target}. ");
// Console.WriteLine($"Return the indexes of the two numbers that add up to the target.");
// Console.WriteLine();
// var result = TwoSum.Optimal(nums, target);
//
// Console.WriteLine($"The indexes of the two numbers is:");
// foreach (var item in result)
//     Console.WriteLine($" {item} ");

#endregion Exc Easy - Two Sum

#region Exc Easy - Two Sum (1-indexed)

int[] nums = [8, 2, 0, 7, 3]; 
var target = 9;
Console.WriteLine($"Given the array:");
Print(nums);
Console.WriteLine($"Find two nums that add up to {target}");
Console.WriteLine($"Return their 1-indices in the array:");
var result = TwoSum.Optimal1Indexed(nums, target);
Print(result);

#endregion Exc Easy - Two Sum (1-indexed)


#region Exc Easy - Valid Parentheses

//var input = "{}[]({})";
//Console.WriteLine($"Given the following string {input}");
//Console.WriteLine();
//Console.WriteLine("Determine if the input is valid.");
//Console.WriteLine();

//var result = ValidParentheses.IsValidOptimal(input);
//Console.WriteLine($"The input is valid? {result}");

#endregion Exc Easy - Valid Parentheses

#region  Exc Easy - Merge Two Sorted Lists

// int[] arr1 = [1, 2, 4];
// var list1 = new LinkedList<int>(arr1);
//
// int[] arr2 = [1, 3, 4, 5, 6];
// var list2 = new LinkedList<int>(arr2);
//
// var result = MergeTwoSortedLists.Solution(list1, list2);
//
// foreach (var item in result)
// {
//     Console.WriteLine(item);
// }

#endregion

#region Exc Easy - Merge Two Sorted Lists - Iterative Solution

// var list1 = new Node(1, new Node(2, new Node(4, null)));
// var list2 = new Node(1, new Node(3, new Node(4, null)));
//
// var result = MergeTwoSortedLists.RecursiveMerge(list1, list2);


#endregion Exc Easy - Merge Two Sorted Lists - Iterative Solution

#region Exc Easy - Max Sum Of Subarray

// int[] arr = [2, 1, 5, 1, 3, 2];
// int size = 3;
//
// var result = MaxSumOfSubarray.MaxSum(arr, size);

#endregion Exc Easy - Max Sum Of Subarray

#region  Exc Easy - Longest Substring Without Repeating
//
// var s = "abcabcbb";
//
// var result = LongestSubstringWoutRepeating.LongestSubstring(s);

#endregion Exc Easy - Longest Substring Without Repeating

#region Exc Easy - Best Profit

//int[] prices = [7, 1, 5, 3, 6, 4];
// int[] prices = [7, 1, 5, 0, 6, 2];
//
// var result = BestTimeProfit.MaxProfit(prices);

#endregion Exc Easy - Best Profit

#region Exc Easy - Valid Anagram

//  var s = "Anagram";
//  var t = "nagaram";
//  // var s = "ab";
//  // var t = "cc";
//
//  var result = ValidAnagram.IsAnagramOptimalLowercase(s, t);
// Console.WriteLine($"Are {s} and {t} anagrams? {result}");

#endregion Exc Easy - Valid Anagram

#region Exc Easy - Contains Num Duplicates

// int[] nums = [1, 2, 3, 1];
//
// var result = ContainsDuplicates.Check(nums);
//
// Console.WriteLine($"Nums: {nums} contains duplicates? {result}");

#endregion Exc Easy - Contains Num Duplicates

#region Exc Easy - Move Zeroes

// int[] nums = [0, 1, 0, 3, 12];
//
// Console.WriteLine("Move zeros from:");
// Print(nums);
//
// var result = MoveZeroes.Move(nums);
//
// Print(result);

#endregion Exc Easy - Move Zeroes

static void Print(int[] items)
{
    Console.WriteLine();
    Console.Write(string.Join(", ", items));
    Console.WriteLine();
}

Console.ReadKey();




