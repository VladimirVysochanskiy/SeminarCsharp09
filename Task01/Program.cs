// Задача 63: Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
//-------------------------------------------------------------------
Console.WriteLine("Вывод чисел от M до N");
Console.WriteLine();
int M = InputNumberControl("Введите число M: ");
int N = InputNumberControl("Введите число N: ");
Console.WriteLine();

PrintNumbersFromTo(M, N);

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

//Вывод чисел от M до N рекурсией.
void PrintNumbersFromTo(int m, int n)
{
    if (m == n+1) return;
    else if (m > n) 
    {
        Console.WriteLine("Ошибка! N должно быть больше чем M.");
        return;
    }
    else
    {
        PrintNumbersFromTo(m+1, n);
        Console.Write($"{m}  ");
    }
}