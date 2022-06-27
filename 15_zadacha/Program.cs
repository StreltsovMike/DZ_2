//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool n;

if (number >= 1 && number <= 5)
{
    n = false;
    Console.WriteLine(n);
}
else if (number > 5 && number <= 7)
{
    n = true;
    Console.WriteLine(n);
}
else
{
    Console.WriteLine("В неделе всего 7 дней");
}