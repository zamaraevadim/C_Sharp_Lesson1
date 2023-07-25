// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.m = 3, n = 4.1 4 8 195 -2 33 -277 3 8 1

// int[,] nums = new int[3,4];

// for(int i = 0;i < nums.GetLength(0);i++){
//     for(int j = 0;j < nums.GetLength(1);j++){
//         nums[i,j] = new Random().Next(0,10);
//     }
// }

// for(int i = 0;i < nums.GetLength(0);i++){
//     for(int j = 0;j < nums.GetLength(1);j++){
//         Console.Write(nums[i,j] + " ");
//     }
//     Console.WriteLine();
// }
///////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.m = 3, n = 4.0 1 2 31 2 3 42 3 4 5
// int[,] nums = new int[3,4];
// for(int i = 0;i < nums.GetLength(0);i++){
//     for(int j = 0;j < nums.GetLength(1);j++){
//         nums[i,j] = i + j;
//     }
// }

// for(int i = 0;i < nums.GetLength(0);i++){
//     for(int j = 0;j < nums.GetLength(1);j++){
//         Console.Write(nums[i,j] + " ");
//     }
//     Console.WriteLine();
// }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// int[,] nums = new int[3,4];
// int sum = 0;
// for(int i = 0;i < nums.GetLength(0);i++){
//     for(int j = 0;j < nums.GetLength(1);j++){
//         nums[i,j] = new Random().Next(0,9);
//     }
// }

// for(int i = 0;i < nums.GetLength(0);i++){
//     for(int j = 0;j < nums.GetLength(1);j++){
//         Console.Write(nums[i,j] + " ");
        
//     }
//     Console.WriteLine();
// }
// int length = 0;
// if(nums.GetLength(0) > nums.GetLength(1)){
//      length = nums.GetLength(1);
// }else{
//     length = nums.GetLength(0);
// }
// for(int i = 0;i < length;i++){
//     sum +=nums[i,i];
// }

// Console.WriteLine(sum);
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// **Задача 53:** Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

int[,] nums = new int[3,4];

for(int i = 0;i < nums.GetLength(0);i++){
    for(int j = 0;j < nums.GetLength(1);j++){
        nums[i,j] = new Random().Next(0,10);
    }
}

for(int i = 0;i < nums.GetLength(0);i++){
    for(int j = 0;j < nums.GetLength(1);j++){
        Console.Write(nums[i,j] + " ");
    }
    Console.WriteLine();
}

for(int i = 0;i < nums.GetLength(1);i++){
    int temp = nums[0,i];
    nums[0,i] = nums[nums.GetLength(0) - 1, i];
    nums[nums.GetLength(0) - 1, i] = temp;
   
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

for(int i = 0;i < nums.GetLength(0);i++){
    for(int j = 0;j < nums.GetLength(1);j++){
        Console.Write(nums[i,j] + " ");
    }
    Console.WriteLine();
}

