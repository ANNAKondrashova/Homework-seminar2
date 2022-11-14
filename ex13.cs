// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
int j = 0;
 do{
        j++;
        num1 = num1/10;
 }
 while (num1 > 0);

 if(j >- 3)
 {
    double step = Math.Pow(10, j-2);
    double count = num % step;
    double result = Math.Floor(count);
    System.Console.WriteLine(Math.Floor(count/Math.Pow(10,j-3)));
 }
 else {
    System.Console.WriteLine("Третьей циры нет");
 }

