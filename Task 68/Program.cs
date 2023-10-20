// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.Write("Введите значение M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

AckermannFunction(numberM, numberN);
Console.Write($"Функция Аккермана A({numberM}, {numberN}) -> {AckermannFunction(numberM, numberN)} ");
