// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] nums = new double[8];
double difference = 0;
for(int i = 0;i < 8;i++){
    nums[i] = Math.Round(new Random().NextDouble() * (99 - 1) + 1,2);
}
Console.WriteLine();
for(int i = 0;i < nums.Length;i++){
    Console.Write(nums[i] + " ");
}

double max = nums[0];
for(int i = 0;i < nums.Length;i++){
    if(max < nums[i]){
        max = nums[i];
    }
}
Console.WriteLine();
Console.WriteLine("max - " + max);

double min = nums[0];
for(int i = 0;i < nums.Length;i++){
    if(min > nums[i]){
        min = nums[i];
    }
}
Console.WriteLine();
Console.WriteLine("min - " + min);
difference = max - min;
Console.WriteLine("Разница между максимальным и минимальным числом: " + difference);