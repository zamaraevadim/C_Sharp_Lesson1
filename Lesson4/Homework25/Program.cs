// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num1;

for(int i = 1;i < num2;i++){
    result *= num1;
}
Console.WriteLine(result);