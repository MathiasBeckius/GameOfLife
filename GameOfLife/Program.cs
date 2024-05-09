// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var twoDimensionalArray = new CoreLib.CircularArray<CoreLib.CircularArray<int>>(3);
for (var i = 0; i < twoDimensionalArray.Length; i++)
    twoDimensionalArray[i] = new CoreLib.CircularArray<int>(3);
twoDimensionalArray[0][0] = 0;
twoDimensionalArray[1][0] = 0;
twoDimensionalArray[2][0] = 0;

var circularArray = new CoreLib.CircularArray<int>(3);
Console.WriteLine($"circularArray[0]={circularArray[0]}");
circularArray[0] = 1;
Console.WriteLine($"circularArray[0]={circularArray[0]}");