// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
max = a;
if (b > a)
{
max = b;
}
if (c > max)
{
max = c;
}

Console.WriteLine(max + " наибольшее число");