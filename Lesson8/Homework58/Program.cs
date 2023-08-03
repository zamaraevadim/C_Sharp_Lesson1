// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] multiplicationMatrix(int[,] matrix1,int[,] matrix2){
    int[,] matrix3 = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    for(int i = 0;i < matrix1.GetLength(0);i++){
        for(int j = 0;j < matrix2.GetLength(1);j++){
            for(int x = 0;x < matrix1.GetLength(1);x++ ){
                matrix3[i,j] += matrix1[i,x] * matrix2[x,j];
            }
    }
    
    }
    return matrix3;
}
int[,] matrix1 = new int[2,2];
int[,] matrix2 = new int[2,2];
int[,] matrix3 = new int[1,1];

if(matrix1.GetLength(1) != matrix2.GetLength(0)){
    Console.WriteLine("Такие матрицы нельзя перемножать");
    Environment.Exit(0);
}else{
    matrix3 = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
}

matrix1 = fillArray(matrix1);
matrix2 = fillArray(matrix2);

PrintArray(matrix1);
PrintArray(matrix2);

matrix3 = multiplicationMatrix(matrix1,matrix2);

PrintArray(matrix3);

