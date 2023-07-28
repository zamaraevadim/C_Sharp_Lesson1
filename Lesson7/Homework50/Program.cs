// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите позиции элемента: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
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

if(m < nums.GetLength(0) && m >= 0 && n < nums.GetLength(1) && n >= 0 ){
    Console.WriteLine(nums[m,n]);
}else{
    Console.WriteLine("такого числа в массиве нет");
}