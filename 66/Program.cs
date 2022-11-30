// Задайте значения M и N.
//  Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

System.Console.Write("Введите число M: ");
int m = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(System.Console.ReadLine());

SumFromMToN(m, n);

void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
    {
        return 0;
    }
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}
System.Console.WriteLine();
System.Console.WriteLine("Для продолжения нажмите любую кнопку:");
System.Console.ReadKey();