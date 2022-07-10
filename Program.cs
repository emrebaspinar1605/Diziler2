//Sort
int[] numberArray={3,5,15,68,89,95,24,12,452,224,14,00,1,74};
System.Console.WriteLine("***** Sırasız Dizi *****");
foreach (var number in numberArray) Console.Write(number+",");
System.Console.WriteLine();
System.Console.WriteLine("***** Sıralı Dizi *****");
Array.Sort(numberArray);
foreach (var number in numberArray) Console.Write(number+",");

//Clear
System.Console.WriteLine();
System.Console.WriteLine("***** Array Clear *****");
Array.Clear(numberArray,2,2);
foreach(var number in numberArray)  Console.Write(number+",");

//Reverse
System.Console.WriteLine();
System.Console.WriteLine("***** Array Reverse *****");
Array.Reverse(numberArray);
foreach (var number in numberArray)  Console.Write(number+",");

//IndexOf 
System.Console.WriteLine();
System.Console.WriteLine("***** Array IndexOf *****");
System.Console.WriteLine(Array.IndexOf(numberArray,5));

//Resize
System.Console.WriteLine("***** Array Resize *****");
Array.Resize<int>(ref numberArray,9);
numberArray[8]=99;
foreach (var number in numberArray) Console.Write(number+",");