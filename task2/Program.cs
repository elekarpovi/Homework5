//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();

System.Console.Write("Введите количество элементов в массиве: ");
int len = Convert.ToInt32(Console.ReadLine());

int [] array = new int [len];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-100,100);
} 

foreach (var item in array)
{
    System.Console.Write(item + ", ");
}
System.Console.WriteLine();

int sum = 0;

for (int i = 1; i < array.Length; i = i + 2)                                 
    {
        sum = sum + array[i];
    }

System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");


