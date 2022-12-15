Console.WriteLine("Введите 2 числа через Enter");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 > number1)
{
    Console.WriteLine("Max " + number2);
}
else
{
    Console.WriteLine("Max " + number1);
}