// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfNaturalElemInRange(int numM, int numN)
{
    if (numM == numN) return numN;

    else return numM + SumOfNaturalElemInRange(numM + 1, numN);
}

Console.WriteLine("Введитеи первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введитеи второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 1 || numberN < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

SumOfNaturalElemInRange(numberM, numberN);
Console.Write($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} равно {SumOfNaturalElemInRange(numberM, numberN)}");
