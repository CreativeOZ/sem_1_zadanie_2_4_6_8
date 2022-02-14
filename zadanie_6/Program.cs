// Выяснить является ли число чётным
Console.Clear();

Console.Write("Введите целое число: ");
int x = int.Parse(Console.ReadLine());
int x2 = x % 2;
Console.WriteLine(x2);
if (x2 == 0)
{
Console.WriteLine("число четное");
}
else
{
Console.WriteLine("Число нечетное");
Console.ReadLine();
}