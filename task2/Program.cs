//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//Вариант подсчета элементов по нечетным индексам:
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

for (int i = 1; i < array.Length; i = i + 2)                                 //начинаем считать с 1
    {
        sum = sum + array[i];
    }

System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");


//Вариант подсчета элементов по нечетному положению в массиве: первый по счету элемент, третий и т.д.:

//Console.Clear();

//System.Console.Write("Введите количество элементов в массиве: ");
//int len = Convert.ToInt32(Console.ReadLine());

//int [] array = new int [len];
//Random rnd = new Random();

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = rnd.Next(-100,100);
//} 

//foreach (var item in array)
//{
//    System.Console.Write(item + ", ");
//}
//System.Console.WriteLine();

//int sum = 0;

//for (int i = 0; i < array.Length; i = i + 2)                            //начинаем считать i с 0
//    {
//        sum = sum + array[i];
//    }

//System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");