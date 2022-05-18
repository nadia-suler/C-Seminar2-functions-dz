// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 99)
{
   Console.WriteLine("Третьей цифры нет"); 
}
else
{
    string stringNumber = Convert.ToString(number);
    Console.WriteLine(stringNumber[2]);
}

