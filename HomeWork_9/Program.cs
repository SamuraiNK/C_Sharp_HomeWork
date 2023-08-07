// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"




int Prompt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;

}





int PrintNumber(int start, int end )
{
    if (start == end) return start;
    else Console.Write($"{PrintNumber(start, end + 1)} ");
    return end;
    
}




int start = Prompt("Введите число: ");
if (start < 1)
{
  Console.WriteLine("Ввдите положительное число!");
  return;
}
Console.WriteLine(PrintNumber(start, 1));







// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30





Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите чесло M");
int m = Convert.ToInt32(Console.ReadLine());




int PrintNumber(int n, int m )
{
    if (n == m)
    {
        return n;
    }
    return PrintNumber(n + 1, m) + n;
}


Console.WriteLine(PrintNumber(n, m));







// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int NumAkkerman(int m, int n)
{
  if (m == 0) 
  {
    return n + 1;
  }
  if (m > 0 && n == 0) 
  {
    return NumAkkerman(m - 1, 1);
  }
  else 
  {
    return NumAkkerman(m - 1, NumAkkerman(m, n - 1));
  }
}

int m = Prompt("Число M: ");
int n = Prompt("Число N: ");

Console.WriteLine($"A({m},{n}) = {NumAkkerman(m, n)}");