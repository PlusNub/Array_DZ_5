//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
Console.WriteLine("В этом массиве: ");
PrintArray(array);

void FillArray(int[] array)
{
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}


int count = 0;

for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
count++;
}
Console.WriteLine($"из {array.Length} чисел, {count} четных");


void PrintArray(int[] array)
{
    Console.Write("[]");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("[]");
    Console.WriteLine();
}