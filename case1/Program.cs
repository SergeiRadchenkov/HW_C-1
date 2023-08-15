Console.Write("Введите число: "); // "456"
// string num = Console.ReadLine()!; // "456"
// int number = int.Parse(num);
int number = int.Parse(Console.ReadLine()!);
int square = number * number;
Console.WriteLine("Квадрат числа " + number + " равен " + square);
Console.WriteLine($"Квадрат числа {number} равен {square}");