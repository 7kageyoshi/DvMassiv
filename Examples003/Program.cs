// 3. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] array = {
//             {4, 3, 1},
//             {2, 6, 9},
//             {4, 6, 2}
//         };

// Console.WriteLine("Исходный массив:");
// PrintArray(array);

// int minSum = int.MaxValue;
// int minRowIndex = -1;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     int currentSum = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         currentSum += array[i, j];
//     }

//     if (currentSum < minSum)
//     {
//         minSum = currentSum;
//         minRowIndex = i;
//     }
// }

// Console.WriteLine($"Строка с индексом {minRowIndex} ");


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

