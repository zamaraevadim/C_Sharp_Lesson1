﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = Convert.ToInt32(Console.ReadLine()); 
int n = Convert.ToInt32(Console.ReadLine()); 

int sum = 0;
sum = recursionMethod(m,n);

Console.WriteLine(sum);


static int recursionMethod(int m,int n){
    
    if (m > n){
        return 0;
    }else{
        return m + recursionMethod(m + 1, n);
    }
    
}
