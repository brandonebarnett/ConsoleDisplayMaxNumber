/* Write a program that takes two numbers from the user and displays the maximum of the two. */

Console.WriteLine("--------------------------------------------------------------------");
Console.WriteLine("-----------------------Display Maximum Number-----------------------");
Console.WriteLine("--------------------------------------------------------------------");
Console.WriteLine();
Console.Write("Please enter your first number: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Please enter your second number: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The maximum number you entered was: " + Math.Max(numberOne, numberTwo));