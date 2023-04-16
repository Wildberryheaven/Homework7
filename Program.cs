// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Clear();
// double[,] CreateRandom2dArray() {
    
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     double[,] array = new double[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = Math.Round((new Random().Next(minValue, maxValue + 1)) + (new Random().NextDouble()), 1);
    
//     return array;
// }

// void Show2dArray(double[,] array) {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

// Console.Clear();
// int[,] CreateRandom2dArray() {
    
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// void Show2dArray(int[,] array) {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void FindElement(int[,] array, int i, int j) {
//     if(i>array.GetLength(0)-1 || j>array.GetLength(1)-1) 
//     Console.WriteLine("Числа с такими индексами в массиве нет!");
//     else Console.Write($"Число с индексами ({i}, {j}) = {array[i,j]}");
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// Console.Write("Введите индекс строки двумерного массива: ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите индекс столбца двумерного массива: ");
// int j = Convert.ToInt32(Console.ReadLine());
// FindElement(myArray, i, j);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Clear();
// int[,] CreateRandom2dArray() {
    
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine();
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// void Show2dArray(int[,] array) {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double[] SredneeArifmArray(int[,] array) {
//     double[] newArray = new double[array.GetLength(1)];
//     double sredneeArifm = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         double sum = 0;
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             sum = sum + array[j,i];
//         }
//         sredneeArifm = sum / array.GetLength(0);
//         newArray[i] = sredneeArifm;
//     }
//     return newArray;
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// double[] myNewArray = SredneeArifmArray(myArray);
// Console.WriteLine($"Среднее арифметическое каждого столбца массива выше:"); 
// Console.Write("{");
// for (int i = 0; i < myNewArray.Length; i++)
// {
//    Console.Write(myNewArray[i] + " ");
// }
// Console.WriteLine("}");
// Console.WriteLine();