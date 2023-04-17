﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// напишите программу которая 
// принимает на вход трехзначное число и на 
// выходе показывает последнюю цифру этого числа
// 456->6
// 782->2
// 918->8

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
    number = -number;
if (number >= 100 && number <= 999)
    Console.WriteLine(number % 10);  // остаток от деления на 10
else
    Console.WriteLine("третьей цифры нет");
