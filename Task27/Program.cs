// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// используем while тк неизвестно кол-во итерраций

// Console.WriteLine("Введите целое число");
// int number = Convert.ToInt32(Console.ReadLine());
// int sumNumbers = SumNumbers(number);
// Console.WriteLine ($"Сумма цифр в числе {number} = {sumNumbers}");
// int SumNumbers(int num)
// {
//     int sum = 0;
//     while (sum > 0; i <= num; i++) 
//     {
//         checked
//         {
//         sum *= i;    // иначе -> sum = sum + 1 // sum/=2; // 
//         }          
//     }  
    
//     return sum;   // сели знаем колво итенраций то for?елси не знаем while

// }


int number = ReadInt("Введите число: ");
int length = NumberLength(number);
SumNumbers(number, length);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int NumberLength(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
