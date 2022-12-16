Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"Это число четное {number}");
}
else
{
    Console.WriteLine($"Это число не чётное {number}");
}
