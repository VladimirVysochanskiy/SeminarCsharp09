//Задайте значение N. Напишите программу, которая выведет все натуральные   
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.  
//N = 5 -> "5, 4, 3, 2, 1"  
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" 
//-------------------------------------------------------------------
Console.WriteLine("Вывод чисел от N до 1");
Console.WriteLine();

int N = InputNumberControl("Введите число N: ");
Console.WriteLine();

PrintNumbersDecrease(N);

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

//Вывод чисел от N до 1 рекурсией.
void PrintNumbersDecrease(int n)
{
    n = Math.Abs(n);
    if (n > 0)
    {
        Console.Write($"{n}  ");
        PrintNumbersDecrease(n - 1);
    }
}