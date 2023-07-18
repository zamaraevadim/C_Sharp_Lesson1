// int[] nums = new int[12];
// int positive_sum = 0;
// int negative_sum = 0;
// for(int i = 0;i < nums.Length;i++){
//     nums[i] = new Random().Next(-9,10);
//     Console.Write(nums[i] + " ");
//     if(nums[i] < 0){
//         negative_sum += nums[i];
//     }else{
//         positive_sum += nums[i];
//     }
// }
// Console.WriteLine("Сумма положительных - " + positive_sum);
// Console.WriteLine("Сумма отрицательных - " + negative_sum);



////////////////////////////////////////////////////////////////////////////////

// int[] nums = new int[12];

// for(int i = 0;i < nums.Length;i++){
//     nums[i] = new Random().Next(-9,10);
//     Console.Write(nums[i] + " ");
// }
// Console.WriteLine();
// for(int j = 0;j < nums.Length;j++){

//     nums[j] = nums[j] * -1;
   
//     Console.Write(nums[j] + " ");
// }



//////////////////////////////////////////////////////////////////////////////////
// int[] nums = new int[12];
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// for(int i = 0;i < nums.Length;i++){
//     nums[i] = new Random().Next(-9,10);
//     Console.Write(nums[i] + " ");
// }
// Console.WriteLine();
// string result = "нет";
// for(int j = 0;j < nums.Length;j++){
//     if(nums[j] == num){
//         result = "Да";
//         break;
//     }
    
// }
// Console.WriteLine(result);
////////////////////////////////////////////////////////////////////////////////
int[] numbers = {1,2,3,4,5};

for(int i = 0 ; i < numbers.Length/2;i++){
    Console.Write(numbers[i] * numbers[numbers.Length - 1 - i]);
}
if(numbers.Length % 2 != 0){
    Console.WriteLine(numbers[numbers.Length/2]);
}



