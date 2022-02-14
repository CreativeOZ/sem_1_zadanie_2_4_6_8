// Показать четные числа от 1 до N
Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
  while(i<N) 
  { 
    i++;        
   if(i%2 == 0) {
    Console.Write("{0} ", i);
   }  
  }
  Console.ReadKey();