using ExampleChallenges.Extensions;

StringHelper stringHelper = new();

#region FizzBuzz

Console.WriteLine("FizzBuzz");
var fizzBuzzNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,14,15 };

stringHelper.WriteToConsoleOfFizzBuzzResult(fizzBuzzNumbers);

#endregion

Console.WriteLine("-------------");

#region String Sum

Console.WriteLine("String Sum");
var sumResult1 = stringHelper.Sum("1", "2");
var sumResult2 = stringHelper.Sum("a", "2");
var sumResult3 = stringHelper.Sum("a", "b");

Console.WriteLine(sumResult1);//3
Console.WriteLine(sumResult2);//2
Console.WriteLine(sumResult3);//0

#endregion

Console.WriteLine("-------------");

#region String Subtraction

Console.WriteLine("String Subtraction");
var subtractResult1 = stringHelper.Subtract("1", "2");
var subtractResult2 = stringHelper.Subtract("5", "4");
var subtractResult3 = stringHelper.Subtract("a", "2");
var subtractResult4 = stringHelper.Subtract("a", "b");

Console.WriteLine(subtractResult1);//-1
Console.WriteLine(subtractResult2);//1
Console.WriteLine(subtractResult3);//-2
Console.WriteLine(subtractResult4);//0

#endregion