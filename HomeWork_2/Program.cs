// Задача 10

 Console.WriteLine ("Привет если ты введёшь трёхзначное число я смогу показать тебе вторую цифру этого числа");
 Console.WriteLine ("Введи число ");

 int result = Convert.ToInt32 (Console.ReadLine ());

 result = result / 10 % 10;


 Console.WriteLine ($"Это число  {result}");


// Задача 13

 Console.WriteLine ("Теперь я назову третию цифру");
 Console.WriteLine ("Введи число ");

 int result_2 = Convert.ToInt32 (Console.ReadLine());
 if (result_2 < 100)
 {
     Console.WriteLine ($"Это число 2-х значное число а надо 3-х значное");
 }
 else
 {
    while (result >= 1000)
    {
        result_2= result_2/10;
    }
    result_2 = result_2 % 10;
    Console.WriteLine ($"Это число {result_2}");
 }



// Задача 15


Console.WriteLine ("Теперь назови цифру дня недели и я скажу выходные это или нет ");

int num_week = Convert.ToInt32 (Console.ReadLine());

if (num_week == 1)
{
    Console.WriteLine ("Это будний день");
}
else if (num_week == 2)
{
    Console.WriteLine ("Это будний день");
}
else if (num_week == 3)
{
    Console.WriteLine ("Это будний день");
}
else if (num_week == 4)
{
    Console.WriteLine ("Это будний день");
}
else if (num_week == 5)
{
    Console.WriteLine ("Это будний день");
}
else
{
    Console.WriteLine ("Это выходной");
}









