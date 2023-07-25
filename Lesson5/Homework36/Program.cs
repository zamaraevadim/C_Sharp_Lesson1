// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] nums = new int[8];
int sum = 0;
for(int i = 0;i < 8;i++){
    nums[i] = new Random().Next(0,100);
}

for(int i = 0;i < nums.Length;i++){
    if(i % 2 != 0){
        sum += nums[i];
    }
}
Console.WriteLine(sum);
