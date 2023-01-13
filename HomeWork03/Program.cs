// Напишите программу вычисления функции Аккермана с помощью рекурсии.  
// Даны два неотрицательных числа m и n.  
// m = 2, n = 3 -> A(m,n) = 9  
// m = 3, n = 2 -> A(m,n) = 29  
//-------------------------------------------------------------------
Console.WriteLine("Вычисление функции Аккермана:");
Console.WriteLine();
double M = InputNumberControl("Введите число M: ");
double N = InputNumberControl("Введите число N: ");
Console.WriteLine();
double F = Ackermann(M, N);
Console.WriteLine($"Число Аккермана при значениях M = {M} и N = {N} равно: \n{F}");
Console.WriteLine();

//-------------------------------------------------------------------
//Метод контроль ввода натурального числа
double InputNumberControl(string text)
{
    System.Console.Write(text);
    double number;
    while (true)
    {
        string? txt = (Console.ReadLine());
        if (double.TryParse(txt, out number) && number >= 0)
        {
            break;
        }
        System.Console.Write("Введенное значение не является натуральным числом. Попробуйте ещё раз: ");
    }
    return number;
}

double Ackermann(double m, double n)
{
    double A = 0;
    if (m == 0) A = n+1;
    else if (m > 0 && n == 0) A = Ackermann(m-1, 1);
    else A = Ackermann(m-1, Ackermann(m, n-1));
    return A;
}
