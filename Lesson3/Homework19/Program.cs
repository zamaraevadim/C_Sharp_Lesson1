// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначаное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[5];
int n = numbers.Length;
int result = 1;
for(int i = 0; i < 5;i++){
numbers[i] = number % 10;
number = number / 10;
}
for(int j = 0; j < numbers.Length/2;j++){
    if(numbers[j] == numbers[n - 1]){
        result *= 1;
    }else{
        result *= 0;
    }
    
    n -= 1;
}
if(result == 0){
    Console.WriteLine("нет");
}else if (result == 1){
    Console.WriteLine("да");
}
