// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] fillArray(int[,,] nums){

for(int i = 0;i < nums.GetLength(0);i++){
    for(int j = 0;j < nums.GetLength(1);j++){
        for(int k = 0;k < nums.GetLength(2);k++){
            nums[i,j,k] = new Random().Next(10,100);
        }
    }
}

return nums;
}

void PrintArray(int[,,] nums){

    
    for(int i = 0;i < nums.GetLength(0);i++){
        for(int j = 0;j < nums.GetLength(1);j++){
            Console.WriteLine();
             for(int k = 0;k < nums.GetLength(2);k++){
                Console.Write(nums[i,k,j] + " - (" + i + "," + k + "," + j +") ");
        }
    }
    Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,]nums = new int[2,2,2];
nums = fillArray(nums);
PrintArray(nums);