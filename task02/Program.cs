// Задание 2.
int[] array = {1, 8, 43, 4, 55, 60, 3, 2, 1, 3};
int count = 0;
for (int i = 0; i < array.Length; i++)
{

    Console.WriteLine("array[{0}]={1}", i, array[i]);
}

for (int i = 0; i < array.Length; i++)
 
    if (array[i] % 2 == 0)
    count++;


Console.WriteLine($"количество чётных чисел в массиве -> {count} ");

