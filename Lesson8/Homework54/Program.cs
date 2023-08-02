// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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


void ArrangeArray(int[,] nums, int i){

    for(int x = 0;x < nums.GetLength(1);x++){
        for(int y = 0;y < nums.GetLength(1) - 1 ;y++){
            if(nums[i,y] < nums[i,y + 1]){
                int temp = nums[i,y];
                nums[i,y] = nums[i,y + 1];
                nums[i,y + 1] = temp;
            }
        }
    }
}


int[,] nums = new int[3,4];
nums = fillArray(nums);

PrintArray(nums);

for(int i = 0; i < nums.GetLength(0);i++){
    ArrangeArray(nums,i);
}

PrintArray(nums);



