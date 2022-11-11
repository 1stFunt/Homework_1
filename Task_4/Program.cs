// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите натуральное число (N): ");
int a = Convert.ToInt32(Console.ReadLine());

int number = 1;
if (a < 0 || a == 0)
{
    Console.WriteLine("Ошибка! Введено НЕ натуральное число (N), попробуйте ещё раз.");
}
while (number <= a)
{
    if (number % 2 == 0)
    {
        Console.Write(number + " ");
        number++;
    }
    else
    {
        number++;
    }
}