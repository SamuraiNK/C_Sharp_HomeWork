// Задача 19

Console.WriteLine("Сейчас я скажу является ли твоё пятизначное число палиндроном");
Console.WriteLine("Введи число");
int numUser = Convert.ToInt32(Console.ReadLine());


    int result_1 = numUser % 10;
    int result_2 = (numUser / 10) %10;

    int result_3 = numUser /10000;
    int result_4 = (numUser /1000) %10;

if ((numUser < 10000) || (numUser > 100000))
{
    Console.WriteLine("Это не пятизначное число");
}

else if ((result_1 == result_3) && (result_2 == result_4))
{
   
    Console.WriteLine("Да это палиндрон");
}
else  
{
    Console.WriteLine("Нет это не палиндром");
}





// Задача 21

Console.WriteLine("Теперь я назвои координаты 2х точек и я назову их расстояние в 3D пространстве");

Console.WriteLine("Введи координату X для первой точки");
int X1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введи координату Y для первой точки");
int Y1 = Convert.ToInt32 (Console.ReadLine());


Console.WriteLine("Введи координату X для второй точки");
int X2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введи координату X для второй точки");
int Y2 = Convert.ToInt32 (Console.ReadLine());


Console.WriteLine("Введи координату Z для первой точки");
int Z1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введи координату Z для второй точки");
int Z2 = Convert.ToInt32 (Console.ReadLine());



double result = Math.Sqrt ((Math.Pow ((X2-X1),2)) + 
                          (Math.Pow ((Y2-Y1),2)) + 
                          (Math.Pow ((Z1-Z2),2)));

result = Math.Round (result,2);
Console.WriteLine(result);




// Задача 23
Console.WriteLine("И последние на сегодня. Я выведу таблицу кубов от 1 до числа которое ты назовёшь");
Console.WriteLine("Напиши число");
int num = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i <= num; i++)
{
    Console.WriteLine(Math.Pow(i,3));
}
