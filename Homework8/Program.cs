Console.WriteLine("Введите число: ");
int num = Int32.Parse(Console.ReadLine());

for(int i = 1; i <= num;i++){
    if(i % 2 == 0){
        Console.Write(i + " ");
    }
}
