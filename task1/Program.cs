//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();

System.Console.Write("Введите количество элементов в массиве: ");
int len = Convert.ToInt32(Console.ReadLine());

int [] array = new int [len];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1000);
} 

foreach (var item in array)
{
    System.Console.Write(item + ", ");
}
System.Console.WriteLine();

int count = 0;
foreach (var item in array)
{
    if (item % 2 == 0)
    {
        count++;
    }
}

System.Console.WriteLine($"Количество четных чисел в массиве: {count}");