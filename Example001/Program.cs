// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int total = Total(number);
Console.WriteLine(total);

int Total(int arg)
{
    int secondLetter = arg/10 % 10;
    return secondLetter;
}
