// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите какое количество чисел вы хотите ввести: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Начинайте вводить числа через Enter");
int count = 0;
for(int i = 0;i < m;i++){
    int num = Convert.ToInt32(Console.ReadLine());
    if(num > 0){
        count++;
    }
}
Console.WriteLine(count + " чисел больше 0 вы ввели");