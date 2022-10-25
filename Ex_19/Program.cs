/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Enter the five-digit number");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int length = numberStr.Length;
int firstHalf = 0;
int secondHalf = 0;
int[] secondDigits = new int[2];
if (length != 5) Console.WriteLine($"{number} is not five-digit number");
else
{
    firstHalf = number / 1000;
    for (int i = 0; i < 2; i++)
    {
        secondDigits[i] = number % 10;
        number = number / 10;
    }
    secondHalf = secondDigits[0] * 10 + secondDigits[1];
    if (firstHalf == secondHalf) Console.WriteLine($"The number {number} is a polyndrom");
    else Console.WriteLine($"The number {number} is not a polyndrom");
}
Console.WriteLine(string.Join(",", secondDigits));
Console.WriteLine(firstHalf);
Console.WriteLine(secondHalf);