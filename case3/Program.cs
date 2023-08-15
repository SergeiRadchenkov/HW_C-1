Console.Write("Введите дня недели от 1 до 7: ");
int weekday = int.Parse(Console.ReadLine()!);

if(weekday == 1)
{
    Console.WriteLine("Понедельник");
}
else if(weekday == 2)
{
    Console.WriteLine("Вторник");
}
else if(weekday == 3)
{
    Console.WriteLine("Среда");
}
else if(weekday == 4)
{
    Console.WriteLine("Четверг");
}
else if(weekday == 5)
{
    Console.WriteLine("Пятница");
}
else if(weekday == 6)
{
    Console.WriteLine("Суббота");
}
else if(weekday == 7)
{
    Console.WriteLine("Воскресенье");
}
else
    Console.WriteLine("Такого дня недели нет");