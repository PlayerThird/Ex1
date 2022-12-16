string str = Console.ReadLine();
string[] parts = str.Split('.');
Console.WriteLine("Целая часть: " + parts[0]);
Console.WriteLine("Дробная часть: " + parts[1]);
//string chislo = parts[1].Substring(parts[1].IndexOf(3));
int ind = parts[1].Length - 1;
parts[1] = parts[1].Remove(0, 2);
Console.WriteLine(parts[1]); 