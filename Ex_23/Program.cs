/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Enter the number");
int number = int.Parse(Console.ReadLine());
int[] cube = new int[number];
int digit = 1;
for (int i = 0; i < number; i++)
{
    cube[i] = digit * digit * digit;
    digit++;
}
Console.Write($"{number} -> ");
Console.WriteLine(string.Join(", ", cube));