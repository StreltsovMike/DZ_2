//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int revers = 0, n;
if (number > 99)
{
    while (number > 0)
    {
        n = number % 10;
        revers = revers * 10 + n;
        number = number / 10;
    }

    revers = revers % 1000;
    revers = revers / 100;

    Console.WriteLine("Третья цифра: " + revers);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}