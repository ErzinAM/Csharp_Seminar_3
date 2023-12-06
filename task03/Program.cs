// Задание 3.
using System.ComponentModel.DataAnnotations;

double[]array = new double[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
   
array[i] = Math.Round(rand.Next(0,10) + rand.NextDouble(), 2);
}

System.Console.WriteLine(string.Join(" ",array));

double max = array.Max();
double min = array.Min();
Console.WriteLine("Максимальный элемент массива = {0}", max);
Console.WriteLine("Минимальный элемент массива = {0}", min);
double result = max - min;
Console.WriteLine("Разность = " + result);
