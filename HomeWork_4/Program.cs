// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число которое будут возводить в степень");
int numA = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введи степень");
int numB = Convert.ToInt32(Console.ReadLine());

int result = numA;

for (int i = 1; i < numB; i++)
{
    result = result * numA;
}

 Console.WriteLine ($"Это число {result}");







// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Напиши число и я выдам сумму цифр в числе");
int number = Convert.ToInt32(Console.ReadLine());


int result_2 = 0;
while ( number > 0)
{
    result_2 = result_2 + number %10;
    number = number /10;
}

System.Console.WriteLine(result);

// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Начальное значения, для диапазона случайного числа");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Конечное значения, для диапазона случайного числа");
int max = Convert.ToInt32(Console.ReadLine());



int arrayLenght = 8; 

int [] array = new int [arrayLenght];
Random random = new Random();

for (int i = 0; i < arrayLenght; i++)
{ 
    array[i] = new Random().Next (min, max);
    Console.WriteLine(array [i]+ " ");
}

    


