﻿Console.Clear();

Console.Write("Сколько элементов Вы хотите ввести: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrString = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write("Введите строку №{0}:\r\n    ", i + 1);
    arrString[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Вы ввели следующие строки: ");
for (int i = 0; i < size; i++)
{
    Console.WriteLine(arrString[i]);
}
var result = new string[arrString.Length];
var count = 0;
foreach (var value in arrString)
{
    if (value.Length <= 3)
    {
        result[count] = value;
        count++;
    }
}
Console.WriteLine();