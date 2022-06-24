// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

void ShowNumer()
{   
    int num = new Random().Next(100, 1000);
    int num1 = num / 100;
    int num3 = num % 10;
    int result = num1 * 10 + num3;
    Console.WriteLine(num + " -> "+ result);

}
ShowNumer();

