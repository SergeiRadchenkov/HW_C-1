Console.Write("Введите дня недели от 1 до 7: ");
int weekday = int.Parse(Console.ReadLine()!);
string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine(days[weekday - 1]);