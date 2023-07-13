// Задача 10

Console.WriteLine ("Привет если ты введёшь трёхзначное число я смогу показать тебе вторую цифру этого числа");
Console.WriteLine ("Введи число ");

int result = Convert.ToInt32 (Console.ReadLine ());

result = result / 10;
result = result % 10;


Console.WriteLine ($"Это число  {result}");

