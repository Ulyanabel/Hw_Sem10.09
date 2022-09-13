// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (n > 0)
{
    int b = n % 10; n = n / 10; sum = sum + b;
}
Console.WriteLine("" + sum);