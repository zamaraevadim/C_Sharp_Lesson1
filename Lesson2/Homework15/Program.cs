// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели чтобы узнать является ли этот день выходным: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 7 || num < 1){
    Console.WriteLine("Такого дня нет");
}else if( num > 5){
    Console.WriteLine("Да");
}else{
    Console.WriteLine("Нет");
}