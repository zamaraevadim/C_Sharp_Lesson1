// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] fillArray(int[,] nums){

for(int i = 0;i < nums.GetLength(0);i++){
    for(int j = 0;j < nums.GetLength(1);j++){
        nums[i,j] = new Random().Next(0,10);
    }
}

return nums;
}

void PrintArray(int[,] nums){
    
    for(int i = 0;i < nums.GetLength(0);i++){
        for(int j = 0;j < nums.GetLength(1);j++){
        Console.Write(nums[i,j] + " ");
    }
    Console.WriteLine();
    }
    Console.WriteLine();
}


int searchLargerString(int[,] nums){
    int min = 0;
    int countString = 0;
    int[] minArray = new int[nums.GetLength(0)];
    for(int x = 0;x < nums.GetLength(0);x++){
        for(int y = 0;y < nums.GetLength(1);y++){
           min += nums[x,y];
        }
        minArray[x] = min;
        min = 0;
    }
    int min1 = minArray[0];
    for(int i = 0;i < minArray.Length;i++){
        
        if(min1 > minArray[i]){
            min1 = minArray[i];
            countString = i;
        }
    }

    return countString + 1;
}


int[,] nums = new int[4,4];
nums = fillArray(nums);

PrintArray(nums);

Console.WriteLine(searchLargerString(nums) + " строка ");


