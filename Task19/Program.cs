﻿// 5ти значное 0- на 1 семинаре, елси - то преобразовать *-1
// сравнить - 1245, если 1=5 и 2=4 тогда полиндром (и это и это) 
//1я цифра- число делить на 10 000, 2/1000, 2/10 и сравнить с остатком
// метод - булевый - тут только 
// - универсальный алгоритм - нужен цикл - 
//развернуть число - если такое же - то полиндром

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций 
//(целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int length = number.Length;
if (length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - да");
    }
    else
    {
        Console.WriteLine($"{number} - нет");
    }
}
else
{
    Console.WriteLine($"проверьте введенное число на количество знаков");
}