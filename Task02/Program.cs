// Задача 67: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
//-------------------------------------------------------------------
Console.WriteLine("Расчёт суммы цифр целого числа");
Console.WriteLine();
int N = InputNumberControl("Введите число: ");
Console.WriteLine();
int sum = SumDigitsRecurs(N);
Console.WriteLine($"Сумма цифр числа {N} = {sum}.");
Console.WriteLine();

//-------------------------------------------------------------------
//Метод контроль ввода целого числа
int InputNumberControl(string text)
{
    System.Console.Write(text);
    int number;
    while (true)
    {
        string? txt = (Console.ReadLine());
        if (int.TryParse(txt, out number))
        {
            break;
        }
        System.Console.Write("Введенное значение не является натуральным числом. Попробуйте ещё раз: ");
    }
    return number;
}

//Сумма цифр числа рекурсией.
int SumDigitsRecurs(int n)
{
    int result = 0;
    if (n < 0) n *= -1;
    if (n > 0) result = n % 10 + SumDigitsRecurs(n / 10);
    return result;
}
