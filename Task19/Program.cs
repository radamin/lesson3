// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write("Enter a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int remainder, rev = 0;
int num = number;
int x = rev;

if (num > 9999 && num < 100000)
{
  while (number > x)
  {
    remainder = number % 10;
    rev = (rev * 10) + remainder;
    number = number / 10;
  }
  if (num == rev)
  {
    Console.WriteLine($"Number {num} is Palindrome.");
  }
  else
  {
    Console.WriteLine($"Number {num} is not Palindrome");
  }
}
else
{
  Console.WriteLine($"Error: {number} is not five-digit number");
}

