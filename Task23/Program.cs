﻿// // // 22 Напишите программу которая принимает на вход число N
// // и выдает таблицу квадратов чисел от 1 до N

// //5->1,4,9,16,25
// //2->1,4


// void TableAllSquares(int num)
// {
//     int index = 1;
//     while (index <= num)
//     {
//         Console.WriteLine($"{index,3}  {index * index,3}"); // ,3-резерв места
//         index++;
//     }
// }
// Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// TableAllSquares(number);

//поменять название методов и переменных
// count * count * count
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void TableAllCubes(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index,3}  {index * index * index,3}"); // ,3-резерв места
        index++;
    }
}
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
TableAllCubes(number);
