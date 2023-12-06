// Задание 1:

int[] N = new int[10];
int count = 0;
Random rand = new Random();

for(int i = 0; i < 10; i++)
{
    N[i] = rand.Next(1,100);

    if(N[i] >= 20 && N[i] <= 90)
    count ++;
}

System.Console.WriteLine(string.Join(" ", N));

{
    Console.WriteLine($"Количество элементов массива -> {count} ");
}

