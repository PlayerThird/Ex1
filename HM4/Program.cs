int a, b, c;
string test = Console.ReadLine(); // Переменная для текста с консоли
string[] splitString = test.Split(' ');// Создали текстовый массив, каждая новая переменная это кусочек текста, отделённый пробелом
int[] ints = new int[3];// Создали новый массив для 3х чисел
for (int i = 0; i < 3; i++ )
{
int x;
int.TryParse(splitString[i], out x); //Парсим, т.е. переделываем переменную string в int
ints[i] = x; // Закидываем результат Парса в массив
}
 // Выше сделали так, чтобы можно было ввести 3 числа в строку
a = ints[0];
b= ints[1];
c = ints[2];
int max = a; 
Console.WriteLine(a);
if (max < b)
{
    max = b;
}
if(max < c)
{
    max = c;
}
Console.WriteLine("Максимальное число = ");
Console.WriteLine(max);