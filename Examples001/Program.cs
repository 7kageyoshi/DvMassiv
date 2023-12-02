// 1. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//    и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] array = {
//             {4, 3, 1},
//             {2, 6, 9},
//         };

// Console.Write("Введите номер строки: ");
// int row = int.Parse(Console.ReadLine());

// Console.Write("Введите номер столбца: ");
// int column = int.Parse(Console.ReadLine());

// if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
// {
//     int element = array[row, column];
//     Console.WriteLine($"Значение элемента в позиции ({row}, {column}): {element}");
// }
// else
// {
//     Console.WriteLine("Элемент с указанными координатами отсутствует в массиве.");
// }



// int[,] array = {
//             {4, 3, 1},
//             {2, 6, 9},
//         };

// Console.Write("Введите номер строки: ");
// int row = int.Parse(Console.ReadLine());

// Console.Write("Введите номер столбца: ");
// int column = int.Parse(Console.ReadLine());

// int element = 0;
// bool elementFound = false;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i == row && j == column)
//         {
//             element = array[i, j];
//             elementFound = true;
//             break;
//         }
//     }
//     if (elementFound) break;
// }

// if (elementFound)
// {
//     Console.WriteLine($"Значение элемента в позиции ({row}, {column}): {element}");
// }
// else
// {
//     Console.WriteLine("Элемент с указанными координатами отсутствует в массиве.");
// }
