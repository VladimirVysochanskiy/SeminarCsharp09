// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
//-------------------------------------------------------------------
Console.WriteLine("Возведение в степень");
Console.WriteLine();
int n = InputNumberControl("Введите возводимое в степень число: ");
int p = InputNumberControl("Введите степень: ");
Console.WriteLine();
int sum = NumToPowerRecurs(n, p);
Console.WriteLine($"{n} в степени {p} = {sum}.");
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

//Возведение в степень рекурсией.
int NumToPowerRecurs(int n, int p)
{
    int result = 1;
    if (p > 0) result = n * NumToPowerRecurs(n, p-1);
    return result;
}
