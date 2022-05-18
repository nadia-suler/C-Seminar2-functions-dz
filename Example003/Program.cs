// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите цифру от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 6 ) 
{
    Console.WriteLine("Будний день");
}
else
{
    Console.WriteLine("Выходной день");
}


