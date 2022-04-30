int count = 0, max = 0, min = 0, sum = 0;
int i = 0;
int[] array = new int[1000];
Random rnd = new Random();

Console.WriteLine("Введите количество элементов в массиве: ");
count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхний и нижний значениz элементов массива: ");
max = Convert.ToInt32(Console.ReadLine());
min = Convert.ToInt32(Console.ReadLine());

if (min > max) 
{
    i = max;
    max = min;
    min = i;
}
i = 0;

Console.WriteLine("массив: ");
genArray(count, min, max);

for (i = 0; i < count; i++) 
    if (i % 2 == 1) sum = sum + array[i];

Console.WriteLine(sum);

void genArray(int N, int minimum, int maximum) 
{ 
    Console.Write("[" + count + "] = ");
    for (i = 0; i < N; i++) 
    {
        array[i] = rnd.Next(minimum, maximum);
        if (i != N-1) Console.Write(array[i] + ", ");
        else  Console.Write(array[i]);
    }
    Console.WriteLine();
}
