// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

if (firstnumber > secondnumber)
{
Console.WriteLine(firstnumber + " наибольшее число");
Console.WriteLine(secondnumber + " наименьшее число"); 
}

else if (firstnumber < secondnumber)
{
Console.WriteLine(secondnumber + " наибольшее число");
Console.WriteLine(firstnumber + " наименьшее число");
}
else
{
Console.WriteLine("Оба числа равны");
}

// Если нужно вывести только наибольшее число то строки 11 и 17 можно исключить из кода