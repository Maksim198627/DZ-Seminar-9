//  Задайте значение N.
//   Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//   Выполнить с помощью рекурсии.


string NumbersRec(int M, int N)
{
    if (M <= N) 
    {
        return NumbersRec(M, N -1) + $"{N} ";
    }
    else return String.Empty;
}
System.Console.Write("Write M: ");
int M = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Write N: ");
int N = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine(NumbersRec(M, N));

System.Console.WriteLine("Для продолжения нажмите любую кнопку:");
System.Console.ReadKey();