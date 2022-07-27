/*
//Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее/

int num1, num2;

Console.Write("Введите число a: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > num1) max = num2;
{
    Console.Write("max = ");
    Console.WriteLine(max);
}

//Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num1, num2, num3;

Console.Write("Введите число a: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max);

//Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N % 2 == 0)
    Console.WriteLine("Да, число N - чётное");
else
    Console.WriteLine("Нет, число N - не чётное");


//ГОТОВО. Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= N)
{
    if(current % 2 == 0)
    
        Console.Write(current + ", ");
    
    current++; 
}
*/