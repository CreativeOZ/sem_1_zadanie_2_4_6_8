// Найти максимальное из трех чисел
Console.Clear();

int NumberA = 11;
int NumberB = 102;
int NumberC = 1010;

if(NumberA > NumberB && NumberA > NumberC)
{
Console.WriteLine("Nubmer Max = " + NumberA);
}  
if(NumberB > NumberC)
{
Console.WriteLine("Number Max = " + NumberB);
}  
else
{
Console.WriteLine("Number Max = " + NumberC);
}
Console.ReadLine();