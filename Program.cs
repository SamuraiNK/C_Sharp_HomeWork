// Задание 2:

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
    Console.Write (number_2);
}




