// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2





// int ArrayLength = 8;
// int [] array = new int [ArrayLength];
// int result = 0;
// string ending1 = "число";
// string ending2 = "числа";
// string ending3 = "чисел";

// Console.Write("[ ");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(99,1000);
//     Console.Write(array[i] + " ");
// }   
//  Console.Write ("]");

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] %2 == 0)
//     {
//         result++;
//     }
// }

// if (result == 1)
// {
//     Console.WriteLine($" В этом массиве {result} чётных {ending1}");
// }

// else if ((result > 1) && (result <= 4))
// {
//     Console.WriteLine($" В этом массиве {result} чётных {ending2}");
// }   

// else if (result >= 5)
// {
//     Console.WriteLine($" В этом массиве {result} чётных {ending3}");
// }






// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int ArrayLength = 5;
// int [] array = new int [ArrayLength];
// int result = 0;

// Console.WriteLine("Назвои диапазон чисел массива (от - до)");
// int MinNumArray = Convert.ToInt32(Console.ReadLine());
// int MaxNumArray = Convert.ToInt32(Console.ReadLine());

// Console.Write("[ ");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(MinNumArray, MaxNumArray)
//     Console.Write(array[i] + " ");
// }   
//  Console.Write ("]");

// for (int i = 0; i < array.Length; i++)
// {
//     if (i % 2 == 0 )
//     {
//         result += array[i];
//     }
// }

// Console.WriteLine($" Сумма элементво массива, стоящих на нечётных позициях равна: {result}");




    




// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// int ArrayLength = 5;
// int [] array = new int [ArrayLength];





// Console.WriteLine("Назвои диапазон чисел массива (от - до)");
// int MinNumArray = Convert.ToInt32(Console.ReadLine());
// int MaxNumArray = Convert.ToInt32(Console.ReadLine());


// Console.Write("[ ");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(MinNumArray, MaxNumArray);
//     Console.Write(array[i] + " ");
// }   
//  Console.Write ("]");



// int imax = 0; 
// int imin = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if (imax < array[i])
//     {
//         imax = array[i];
//     }
//     if (imin > array[i])
//     {
//         imin = array[i];
//     }

    
// }

// int result = imax - imin;

// Console.WriteLine($"Разница между максимальным и минимальным числом массива равна: {result}");





























