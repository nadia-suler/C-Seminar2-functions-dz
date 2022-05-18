// Игра-угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
int numberA = RandomInt(10, 1000);

while(true)
{
    Console.Write("Введите число от 10 до 1000: ");
    int numberB = Convert.ToInt32(Console.ReadLine());

    if(numberA == numberB) 
    {
        Console.Write("Правильно!");
        break;
    }
    else 
    {
        if(numberA > numberB) 
        {
            Console.WriteLine("Загаданное число больше");
        }
        else
        {
           Console.WriteLine("Загаданное число меньше");
        }
    }

    
}



int RandomInt(int min, int max)
{
    return new Random().Next(min, max);
}