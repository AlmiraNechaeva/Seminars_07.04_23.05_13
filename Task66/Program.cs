// /Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите чилое натуральное число M");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите чилое натуральное число N");
int number1 = Convert.ToInt32(Console.ReadLine());

SumNaturalNumbers(number, number1);

void SumNaturalNumbers(int num1, int num2)
{
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        SumNaturalNumbers(num1 + num2, (num2 - num1 + 1) / 2);
    }
    else (num1 > num2);
    {
        Console.Write($"{num1} ");
        SumNaturalNumbers(num2 - num1, (num1 - num2 + 1) / 2);
    }

}