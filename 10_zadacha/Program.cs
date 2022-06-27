Console.WriteLine("Ведите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number > 99)
{
    number = number % 100;
    number = number / 10;
    Console.WriteLine($"Стреднее число {number}");
}
else
{
    Console.WriteLine("Число не трехзначное");
}
