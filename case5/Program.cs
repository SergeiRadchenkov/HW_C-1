﻿Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int thirdDigit = number %10;
int secondDigit = number /10 %10;
int firstDigit = number /100;
Console.WriteLine($"Первая цифра {number} равна {firstDigit}");
Console.WriteLine($"Вторая цифра {number} равна {secondDigit}");
Console.WriteLine($"Третья цифра {number} равна {thirdDigit}");
