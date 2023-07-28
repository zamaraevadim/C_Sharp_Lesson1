// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] nums = new int[3,3];

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

// int[,] nums1 = new int[3,3];

// for(int i = 0;i < nums.GetLength(1);i++){
    
//     for(int j = 0;j < nums.GetLength(0);j++){
        
//         nums1[i,j] = nums[j,i];
//     }
    
    
    
// }
// Console.WriteLine("/////////////////////////////////////////////////");
// Console.WriteLine();
// for(int i = 0;i < nums1.GetLength(1);i++){
//     for(int j = 0;j < nums1.GetLength(0);j++){
//         Console.Write(nums1[i,j] + " ");
//     }
//     Console.WriteLine();
// }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// int[,] nums = new int[3,3];

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
// Console.WriteLine();
// int count = 0;
// for(int i = 0;i < nums.GetLength(0);i++){
//     for(int j = 0;j < nums.GetLength(1);j++){
//        for(int x = 0;x < nums.GetLength(0);x++){
//         for(int y = 0;y < nums.GetLength(1);y++){
//             if(nums[i,j] == nums[x,y]){
//                 count++;
//             }
//         }
//        }
//        Console.WriteLine(nums[i,j] + " - " + count);
//        count = 0;
//     }
// }


int[,] nums = new int[3,3];
int[] check = new int[10];

for(int i = 0;i < nums.GetLength(0);i++){
    for(int j = 0;j < nums.GetLength(1);j++){
        nums[i,j] = new Random().Next(0,10);
    }
}

for(int i = 0;i < nums.GetLength(0);i++){
    for(int j = 0;j < nums.GetLength(1);j++){
        Console.Write(nums[i,j] + " ");
        check[nums[i,j]]++;
    }
    Console.WriteLine();
}
Console.WriteLine();

for(int j = 0;j < check.Length;j++){
        Console.WriteLine(j + " - " + check[j]);
    }
    Console.WriteLine();