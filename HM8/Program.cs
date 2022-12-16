Console.WriteLine("Введите число от 1");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < x; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($" " + (i) + " ");
    }
}