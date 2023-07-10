Console.WriteLine("Введите три числа: ");
int number1 = Int32.Parse(Console.ReadLine());
int number2 = Int32.Parse(Console.ReadLine());
int number3 = Int32.Parse(Console.ReadLine());
int max = 0;
if(number1 > number2){
    max = number1;
}else{
    max = number2;
}
if(max > number3){
    Console.WriteLine(max);
}else{
    Console.WriteLine(number3);
}