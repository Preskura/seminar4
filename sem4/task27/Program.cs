// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNumbers (int num)
{
    if (num == 0) return 0;
    return  (num % 10) + SumNumbers(num/10);
    
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма всех цифр числа : "+SumNumbers(number));
