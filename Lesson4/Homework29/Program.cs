﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] nums = new int[8];
for(int i = 0;i < 8;i++){
    nums[i] = new Random().Next(0,11);
}
var str = string.Join(" ", nums);
Console.WriteLine(str);