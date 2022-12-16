Console.WriteLine("Введите ТОЛЬКО 3-х значное число");
string str = Console.ReadLine();
str = str.Remove(0, 2);
Console.WriteLine(str); 