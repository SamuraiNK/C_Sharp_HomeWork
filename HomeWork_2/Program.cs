// Задача 10

// Console.WriteLine ("Привет если ты введёшь трёхзначное число я смогу показать тебе вторую цифру этого числа");
// Console.WriteLine ("Введи число ");

// int result = Convert.ToInt32 (Console.ReadLine ());

// result = result / 10;
// result = result % 10;


// Console.WriteLine ($"Это число  {result}");


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
    result_2 = result_2 % 10;
Console.WriteLine ($"Это число {result_2}");
}








