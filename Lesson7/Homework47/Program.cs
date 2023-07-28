﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

double[,] nums = new double[m,n];

for(int i = 0;i < nums.GetLength(0);i++){
    for(int j = 0;j < nums.GetLength(1);j++){
        nums[i,j] = Math.Round(new Random().NextDouble(),2);
    }
}

for(int i = 0;i < nums.GetLength(0);i++){
    for(int j = 0;j < nums.GetLength(1);j++){
        Console.Write(nums[i,j] + " ");
    }
    Console.WriteLine();
}