int magicNumber = 4;

Console.WriteLine("Угадай число");
Console.WriteLine();
Console.WriteLine("Загадано число от 1 до 5. Попробуйте его отгадать!");
Console.WriteLine();
Console.Write("Введите ваше число: ");
int input = Convert.ToInt32(Console.ReadLine());

//

if (input == 1)
{
    Console.WriteLine("Нет! Это не " + input + "!");
}
else if (input == 2)
{
    Console.WriteLine("Нет! Это не " + input + "!");
}
else if (input == 3)
{
    Console.WriteLine("Нет! Это не " + input + "!");
}
else if (input == 5)
{
    Console.WriteLine("Нет! Это не " + input + "!");
}
else if (input == 4)
{
    Console.WriteLine("Да! Это число " + magicNumber + "!");
}