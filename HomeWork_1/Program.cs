﻿ //Задание 2:

Console.WriteLine ("Я програма которая умеет из 2 чисел называть наибольшее");
Console.WriteLine ("Давай попробуем, напиши первое число");
int number_1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Отлично а теперь введи второе");
int number_2 = Convert.ToInt32 (Console.ReadLine());
 
if (number_1 > number_2)
{
    Console.WriteLine ("Это число");
    Console.Write (number_1 );
}
if (number_1 < number_2)
{
    Console.WriteLine ("Это число");
    Console.WriteLine (number_2);
}




// Задание 4:

Console.WriteLine ("Я стала умнее");
Console.WriteLine ("Теперь я могу назвать наибольшее из 3 чисел");

Console.WriteLine ("Напиши первое число");
int a = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("Напиши второе число");
int b = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("Напиши третье число");
int c = Convert.ToInt32 (Console.ReadLine ());

int max_num = 0;

if (a > b)
{
    max_num = a;
}
if (a < b)
{
    max_num = b;
}
if (max_num < c)
{
    max_num = c;
}
Console.WriteLine (max_num);





// // Задача 6:

Console.WriteLine ("Теперь я могу говорить какое число чётное, а какое нет");

Console.WriteLine ("Напиши любое число");
double result = Convert.ToInt32 (Console.ReadLine ());

if (result % 2 > 0 )
{
    Console.WriteLine ("Оно нечётное");
}
else
{
    Console.WriteLine ("Да, оно чётное");
}





// Задача 8

Console.WriteLine ("А теперь что нибдуь послжнее");
Console.WriteLine ("Я назову все чётные от одного до числа которое ты назовёшь");
Console.WriteLine ("Напиши любое число");

int x = Convert.ToInt32 (Console.ReadLine ());
int i = 0;

while (i < x)
{
    Console.WriteLine (i);
    i += 2;   
}