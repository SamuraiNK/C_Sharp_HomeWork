﻿// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количство столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix= new double[rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().NextDouble(); 
//         Console.Write(matrix[i,j]+ " ");
//     }           
// Console.WriteLine();
// }



// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет






// Console.WriteLine("Введите количество строк в массиве");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов в массиве");
// int columns = Convert.ToInt32(Console.ReadLine());



// int [,] matrix = new int[4 , 4];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {  
//         matrix[i,j] = new Random().Next(0,11);
//         Console.Write(matrix[i,j]+ " ");
       
//     }   
//    System.Console.WriteLine();
        
// }




// Console.WriteLine("Введите индекс строки массива");
// int inum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите индекс столбца массива");
// int jnum = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {  
//        if ((inum == i) && (jnum == j))
//        {
//         Console.WriteLine("Ваше число " + matrix[i,j]);
//        }

           
//     }   
   
       
// }







// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количство столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());



// int [,] matrix= new int [rows,columns];

// for (int i = 0; i < matrix.GetLength(1); i++)
// {
//     for (int j = 0; j < matrix.GetLength(0); j++)
//     {
//         matrix[i,j] = i+j;
//         Console.Write(matrix[i,j]+ " ");
//     }           
// Console.WriteLine();
// }

