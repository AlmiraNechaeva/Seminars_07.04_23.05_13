﻿// Задача 6: Напишите программу, которая 
// на вход принимает число и 
// выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да // -3 -> нет // 7 -> нет

Console.Write("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
bool result = MultipleTwo(number, 2);
Console.WriteLine(result ? "да" : "нет");
bool MultipleTwo(int number, int number1)
{
    return number % 2 == 0;
}


