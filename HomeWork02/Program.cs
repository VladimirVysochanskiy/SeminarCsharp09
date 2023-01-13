// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных   элементов в промежутке от M до N.  
// M = 1; N = 15 -> 120  
// M = 4; N = 8. -> 30  
//-------------------------------------------------------------------
Console.WriteLine("Сумма чисел от M до N");
Console.WriteLine();
int M = InputNumberControl("Введите число M: ");
int N = InputNumberControl("Введите число N: ");
int temp;
if (M > N)
{
    temp = N;
    N = M;
    M = temp;
}
Console.WriteLine();
int sum = SumNumbersFromToRecurs(M, N);
Console.WriteLine($"Сумма чисел от {M} до {N} = {sum}.");
Console.WriteLine();

//-------------------------------------------------------------------
//Метод контроль ввода натурального числа
int InputNumberControl(string text)
{
    System.Console.Write(text);
    int number;
    while (true)
    {
        string? txt = (Console.ReadLine());
        if (int.TryParse(txt, out number) && number >= 0)
        {
            break;
        }
        System.Console.Write("Введенное значение не является натуральным числом. Попробуйте ещё раз: ");
    }
    return number;
}

//Сумма чисел от M до N рекурсией.
int SumNumbersFromToRecurs(int m, int n)
{
    int result = 0;
    if (n > m-1) result = n + SumNumbersFromToRecurs(m, n-1);
    return result;
}
