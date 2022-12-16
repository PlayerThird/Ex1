Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int nonmber = number * (-1);
Console.Write(nonmber);
while (nonmber != number)
{
    nonmber++;
    Console.Write(" ");
    Console.Write(nonmber);
}
