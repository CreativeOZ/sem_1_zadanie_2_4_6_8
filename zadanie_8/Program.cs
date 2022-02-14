// Показать четные числа от 1 до N
Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int N2 = 1;
int count = N;
N = N - (N2*2);
while (N <= count)
{
if (count % 2 == 0)
{
    Console.WriteLine(count + " ");
}}