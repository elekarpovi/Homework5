//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();

System.Console.Write("Введите количество элементов в массиве: ");
int len = Convert.ToInt32(Console.ReadLine());

double [] array = new double [len];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-10, 10) + rnd.NextDouble();
} 

foreach (var item in array)
{
    System.Console.Write(Math.Round(item, 2) + ", ");
}
System.Console.WriteLine();

double max = array[0];
for (int i = 0; i < array.Length; i++)
{
   if (array[i] > max) max = array[i];
}
System.Console.Write($"Максимальный элемент = {Math.Round(max, 2)}");
System.Console.WriteLine();

double min = array[0];
for (int i = 0; i < array.Length; i++)
{
   if (array[i] < min) min = array[i];
}
System.Console.Write($"Минимальный элемент = {Math.Round(min, 2)}");
System.Console.WriteLine();

double result = max - min;
System.Console.Write($"Разница между максимальным и минимальным элементами: {Math.Round(result, 2)}");