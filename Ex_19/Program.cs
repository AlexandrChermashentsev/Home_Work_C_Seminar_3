/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Enter the five-digit number");
int number = Convert.ToInt32(Console.ReadLine());
int length = number.ToString().Length;
int firstHalf = 0;
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
    if (firstHalf == secondDigits[0] * 10 + secondDigits[1]) Console.WriteLine("it's a palindrome");
    else Console.WriteLine("It's not a palindrome");
}
