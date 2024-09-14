﻿// See https://aka.ms/new-console-template for more information
using LeetCode_questions.Scripts;
using LeetCode_questions.Scripts.Easy;
using LeetCode_questions.Scripts.Medium;

#region sumofdigitsofstring
//while (true)
//{

//    Console.Write("Write a word: ");
//    var phrase = Console.ReadLine()!;
//    Console.WriteLine("Please enter k:");
//    var stringnumber = Console.ReadLine()!;

//    var number = int.Parse(stringnumber);
//    SumofDigitsofStringAfterConvert sumofDigitsofStringAfterConvert = new SumofDigitsofStringAfterConvert();
//    var sum = sumofDigitsofStringAfterConvert.GetLucky(phrase, number);


//    Console.WriteLine($"The result is {sum}");
//}
#endregion

#region Palindrome number
//var palindrome = new PalindromeNumber();
//var result = palindrome.IsPalindrome(122);
//Console.WriteLine(result);
//result = palindrome.IsPalindrome(-121);
//Console.WriteLine(result);
//result = palindrome.IsPalindrome(14941);
//Console.WriteLine(result);
#endregion

#region container operations
//var container = new ContainerOperations();
//var query = new string[][]
//{
//    ["ADD","0"],
//     ["ADD","1"],
//     ["ADD","1"],
//     ["ADD","11"],
//     ["ADD","22"],
//     ["ADD","3"],
//     ["ADD","5"],
//     ["GET_NEXT","0"],
//     ["GET_NEXT","1"],
//     ["REMOVE","1"],
//     ["GET_NEXT","1"],
//     ["ADD","0"],
//     ["ADD","1"],
//     ["ADD","2"],
//     ["ADD","1"],
//     ["GET_NEXT","1"],
//     ["GET_NEXT","2"],
//     ["GET_NEXT","3"],
//     ["GET_NEXT","5"]
//};

//var result = container.Solution(query);

//foreach (var item in result)
//{ 
//    Console.WriteLine(item);
//}
#endregion

#region Database simple operations
//database
//var container = new DatabaseOperations();
//var query = new string[][]
//{
//    ["SET","A","B","C"],
//     ["SET","A","D","E"],
//     ["GET","A", "D"],
//     ["DELETE", "A","D"],
//     ["GET","A", "D"],
//};

//var result = container.Solution(query);

//foreach (var item in result)
//{
//    var str = item;
//    if(item == "") { str = "\"\""; }
//    Console.Write(str);
//    Console.Write(",");
//}
#endregion

#region Roman to Integer
//var romanToInteger = new RomanToInteger();
//var result = romanToInteger.Solution("III");
//Console.WriteLine(result);
//result = romanToInteger.Solution("LVIII");
//Console.WriteLine(result);
//result = romanToInteger.Solution("MCMXCIV");
//Console.WriteLine(result);
#endregion

#region Minimum Bit Flips
//var bitFlipp = new MinimumBitFlips();
//var result = bitFlipp.Solution(10, 7);
//Console.WriteLine(result);
//result = bitFlipp.Solution(3, 4);
//Console.WriteLine(result);
#endregion

#region Longst Common Prefix
//var longestCommonPrefix = new LongestCommonPrefix();
//string[] strings =
//{
//    "flower","flowing","flowest","flowrring", 
//    //"dog","racecar","car"
//};
//var result = longestCommonPrefix.Solution(strings);
//if (result == null || string.IsNullOrEmpty(result))
//{
//    result = "\"\"";
//}
//Console.WriteLine(result);
#endregion

#region Count ConsistentStrings
//var consistentString = new CountConsistentStrings();
//string[] strings =
//{
//    "ad","bd","aaab","baa","badab"
//    //"a","b","c","ab","ac","bc","abc"
//    //"cc","acd","b","ba","bac","bad","ac","d"
//};
////string allowed = "ab";
////string allowed = "abc";
//string allowed = "ab";
//var result = consistentString.Solution(allowed ,strings);
//Console.WriteLine(result);
//allowed = "abc";
//strings = new string[]
//{
//    //"ad","bd","aaab","baa","badab"
//    "a","b","c","ab","ac","bc","abc"
//    //"cc","acd","b","ba","bac","bad","ac","d"
//};
//result = consistentString.Solution(allowed, strings);
//Console.WriteLine(result);
//allowed = "cad";
//strings = new string[]
//{
//    //"ad","bd","aaab","baa","badab"
//    //"a","b","c","ab","ac","bc","abc"
//    "cc","acd","b","ba","bac","bad","ac","d"
//};
//result = consistentString.Solution(allowed, strings);
//Console.WriteLine(result);
#endregion

#region Valid Parenthesis
//var validparenthesis = new ValidParenthesis();
//var result = validparenthesis.Solution("()");
//Console.WriteLine(result);
//result = validparenthesis.Solution("()[]{}");
//Console.WriteLine(result);
//result = validparenthesis.Solution("(]");
//Console.WriteLine(result);
//result = validparenthesis.Solution("([])");
//Console.WriteLine(result);
#endregion

#region Merge Two sorted Lists
// Crear las dos listas enlazadas para la prueba
ListNode list1 = ListNodeUtils.Create(new int[] { 1, 2, 4 });
ListNode list2 = ListNodeUtils.Create(new int[] { 1, 3, 4 });

// Imprimir las listas antes de combinarlas
Console.WriteLine("Lista 1:");
ListNodeUtils.Print(list1);

Console.WriteLine("Lista 2:");
ListNodeUtils.Print(list2);

// Llamar a la función MergeTwoLists
var mergeTwoLists = new MergeTwoSortedLists();
ListNode mergedList = mergeTwoLists.Solution(list1, list2);

// Imprimir la lista combinada
Console.WriteLine("Lista combinada:");
ListNodeUtils.Print(mergedList);
#endregion