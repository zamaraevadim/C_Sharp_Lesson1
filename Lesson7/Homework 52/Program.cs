// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

double[] middleNums = new double[nums.GetLength(1)];
int count = 0;
for(int i = 0;i < nums.GetLength(1);i++){
    double middle = 0;
    for(int j = 0;j < nums.GetLength(0);j++){
        middle += nums[j,count];
    }
    middle = Math.Round(middle / nums.GetLength(0),1);
    middleNums[count] = middle;
    count++;
    
}

var str = string.Join(" ", middleNums);
Console.WriteLine("Среднее арифметическое каждого столбца: " + str);
