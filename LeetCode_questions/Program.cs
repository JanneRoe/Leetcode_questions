// See https://aka.ms/new-console-template for more information
using LeetCode_questions.Scripts;

while (true)
{

    Console.Write("Write a word: ");
    var phrase = Console.ReadLine()!;
    Console.WriteLine("Please enter k:");
    var stringnumber = Console.ReadLine()!;

    var number = int.Parse(stringnumber);
    SumofDigitsofStringAfterConvert sumofDigitsofStringAfterConvert = new SumofDigitsofStringAfterConvert();
    var sum = sumofDigitsofStringAfterConvert.GetLucky(phrase, number);


    Console.WriteLine($"The result is {sum}");
}
