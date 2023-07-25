// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int newNum = num;
while(newNum != 0){
    newNum = newNum / 10;
    sum = sum + num % 10;
    num = newNum;
}
Console.WriteLine(sum);