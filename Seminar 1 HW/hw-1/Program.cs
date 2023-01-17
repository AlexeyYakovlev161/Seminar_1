//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
int max=0;
Console.Write("введите первое число:");
int firstNumber=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int secondnumber=Convert.ToInt32(Console.ReadLine());
if (firstNumber>secondnumber)
{
   max=firstNumber;
}
else
{
   max =secondnumber;
} 
Console.WriteLine("max = " + max);