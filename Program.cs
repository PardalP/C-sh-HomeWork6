Console.Clear();

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] CreateArray(int size)
// {
//     int[] num = new int[size];
//     System.Console.Write("Массив: ");
//     for (int i = 0; i < num.Length; i++)
//     {
//         num[i] = new Random().Next(-15, 15);
//     }
//     return num;
// }

// int PosintiveNum(int[] num)
// {
//     int count = 0;
//     foreach (int number in num)
//     {
//         if (number > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// void PrintArray(int[] num)
// {
//     for (int i = 0; i < num.Length; i++)
//     {
//         Console.Write($"{num[i]}, ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);


// int positive = PosintiveNum(array);
// PrintArray(array);
// System.Console.WriteLine($"Число чисел больше 0: {positive}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Введите значение b1: ");
// double b1 = double.Parse(Console.ReadLine());

// Console.Write("Введите значение k1: ");
// double k1 = double.Parse(Console.ReadLine());

// Console.Write("Введите значение b2: ");
// double b2 = double.Parse(Console.ReadLine());

// Console.Write("Введите значение k2: ");
// double k2 = double.Parse(Console.ReadLine());

// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;

// Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");

// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
// Пример:
// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

static int[] NegaFibonacci(int k)
{
    int[] result = new int[k];

    if (k >= 1)
        result[0] = 0;

    if (k >= 2)
        result[1] = 1;

    if (k >= 3)
    {
        for (int i = 2; i < k; i++)
        {
            result[i] = result[i - 2] - result[i - 1];
        }
    }

    return result;
}


int k = 17;
int[] negaFibonacciSequence = NegaFibonacci(k);

foreach (int num in negaFibonacciSequence)
{
    Console.Write(num + " ");
}
System.Console.WriteLine();