﻿// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int rndNum = new Random().Next(10,100);
// Console.WriteLine($"Случайное число из отрезка 10 - 99 => {rndNum}");
// int firstDigit = rndNum / 10;
// int secondDigit = rndNum % 10; 
// Console.Write($"Наибольшая цифра числа {rndNum} =>");

// if (firstDigit > secondDigit) Console.WriteLine(firstDigit);
// else Console.WriteLine(secondDigit);

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine(result);

// void function(string str)
// {
//     Console.WriteLine("str);
//     }

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;  
    if (firstDigit == secondDigit) return 0; 
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

rndNum = 88;
int maxDigit = MaxDigit (rndNum);
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры одинаковые";
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {result}");

// string s = "Hello!";
// function(s);



// int rndNum3 = new Random();
// while (true)
// {
// int rnd = rndNum3.Next();
// }