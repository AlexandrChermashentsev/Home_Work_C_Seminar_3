/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
Distance = √((x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2)
*/

double GetDistance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return distance;
}

int UserNumber (string message)
{
    int numberUser;
    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            numberUser = number;
            break;
        }
        else Console.WriteLine("Введите число, а не что то другое");
    }
    return numberUser;
}

int x1Number = UserNumber("Введите x1");
int y1Number = UserNumber("Введите y1");
int z1Number = UserNumber("Введите z1");
int x2Number = UserNumber("Введите x2");
int y2Number = UserNumber("Введите y2");
int z2Number = UserNumber("Введите z2");

double myDistance = GetDistance(x1Number, y1Number, z1Number, x2Number, y2Number, z2Number);

Console.WriteLine($"Расстояние между точками ({x1Number}, {y1Number}, {z1Number}) и ({x2Number}, {y2Number}, {z2Number}) составляет {Math.Round(myDistance, 3)}.");