// 2. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


// int[,] array = {
//             {4, 3, 1},
//             {2, 6, 9},
//             {4, 6, 2}
//         };

// Console.WriteLine("Исходный массив:");
// PrintArray(array);

// SwapRows(array, 0, array.GetLength(0) - 1);

// Console.WriteLine("Массив после замены:");
// PrintArray(array);


// static void SwapRows(int[,] array, int row1, int row2)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         int temp = array[row1, i];
//         array[row1, i] = array[row2, i];
//         array[row2, i] = temp;
//     }
// }

// static void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
