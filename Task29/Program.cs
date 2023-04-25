// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//как 30 - диапозон от 0 до 100 - 1 массив
//заполненный
// нулями и единицами в случайном порядке

Console.WriteLine("Введите длину массива");
int lenghtArray = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(lenghtArray);
PrintArray(arr);

int[] CreateArray(int size)
{
    int[] array = new int[size];    /// заполнится нулями без скобо {} или //int[] arr = {4,6,6,}
    Random random = new Random(); //оптимизация объекта Random (var - объект неявной типизации)
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);   //01234567
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($" {array[i]}"); //($"Вторая цифра, '{secondRank}'");
    }
}
// Console.ReadKey();
//}