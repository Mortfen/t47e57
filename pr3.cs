
//Задание 1
using System.Diagnostics.CodeAnalysis;

void task1()
{
    int sim = 0;
    Random rnd = new Random();
    Console.Write("Введите длину списка:");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.Write("Нижняя граница генерации:");
    int z = Convert.ToInt32(Console.ReadLine());
    Console.Write("Верхняя граница генерации:");
    int s = Convert.ToInt32(Console.ReadLine());
    int[] a = new int[c];
    for (int i = 0; i < c; i++)
    {
        a[i] = rnd.Next(z, s + 1);
        sim = sim + a[i];
    }
    foreach (var y in a) { Console.WriteLine(y); }
    Console.WriteLine($" {sim} - итоговая сумма");
}
task1();
//Задание 2
void task2()
{

    Random rnd = new Random();
    Console.Write("Введите длину списка:");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.Write("Нижняя граница генерации:");
    int z = Convert.ToInt32(Console.ReadLine());
    Console.Write("Верхняя граница генерации:");
    int s = Convert.ToInt32(Console.ReadLine());
    int[] a = new int[c];
    for (int i = 0; i < c; i++)
    {

        a[i] = rnd.Next(z, s + 1);
        Console.WriteLine(a[i]);
    }
    int sim = a[0];
    foreach (int y in a)
    {

        if (y > sim) { sim = y; }
    }
    Console.WriteLine($" {sim} - максимальное значение");
}
task2();
//Задание 3
void task3()
{

    Random rnd = new Random();
    Console.Write("Введите длину списка:");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.Write("Нижняя граница генерации:");
    int z = Convert.ToInt32(Console.ReadLine());
    Console.Write("Верхняя граница генерации:");
    int s = Convert.ToInt32(Console.ReadLine());
    int[] a = new int[c];
    int c2 = 0;
    for (int i = 0; i < c; i++)
    {

        a[i] = rnd.Next(z, s + 1);
        Console.WriteLine(a[i]);

    }
    Console.WriteLine("Список чётных значений:");
    foreach (int i in a) { if (i % 2 == 0) { Console.WriteLine(i); } }
}
task3();
//Задание 4
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.Arm;
using System.Linq;

void task4()
{
    char[] alf = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    char[] alg = "!?@$;%:^&*()_-+=/|.`~".ToCharArray();
    char[] als = "1234567890".ToCharArray();
    char[] all = alf.Concat(alf).Concat(alg).Concat(als).ToArray();
    Random rnd = new Random();
    Console.WriteLine("Введите длину пароля:");

    int c = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ваш пароль:");
    char[] b = new char[c];
    for (int i = 0; i < b.Length; i++)
    {
        b[i] = all[rnd.Next(all.Length)];
        Console.Write(b[i]);
    }

}
task4();
//Задание 5
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.Arm;
using System.Collections.Generic;
using System;
using System.Collections.Generic;

void task3()
{
    Console.Write("Введите длину списка:");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите массив:");
    int[] a = new int[c];

    for (int i = 0; i < a.Length; i++)
    {
        a[i] = Convert.ToInt32(Console.ReadLine());
    }

    bublgoom(a);
    List<int> uniqueList = RemoveDuplicates(a);

    Console.WriteLine("Массив без повторов:");
    foreach (int i in uniqueList)
    {
        Console.WriteLine(i);
    }
}

static void bublgoom(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        for (int j = 0; j < a.Length - i - 1; j++)
        {
            if (a[j] > a[j + 1])
            {
                int rez = a[j];
                a[j] = a[j + 1];
                a[j + 1] = rez;
            }
        }
    }
}

static List<int> RemoveDuplicates(int[] a)
{
    List<int> uniqueList = new List<int>();
    if (a.Length == 0) return uniqueList;

    uniqueList.Add(a[0]);

    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] != a[i - 1])
        {
            uniqueList.Add(a[i]);
        }
    }

    return uniqueList;
}

task3();
//Задание 6
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.Arm;
using System.Collections.Generic;
using System;
using System.Collections.Generic;

void task2()
{

    Random rnd = new Random();
    Console.Write("Нижняя граница генерации:");
    int z = Convert.ToInt32(Console.ReadLine());
    Console.Write("Верхняя граница генерации:");
    int s = Convert.ToInt32(Console.ReadLine());
    int a = 0;
    a = rnd.Next(z, s + 1);
    int k = 0;
    do
    {
        Console.Write("Введите вашу догадку: ");
        k = Convert.ToInt32(Console.ReadLine());
        if (k < z || k > s)
        {
            Console.WriteLine("Введенное число вне диапазона. Попробуйте снова.");
        }
        else if (k < a)
        {
            Console.WriteLine("Загаданное число больше.");
        }
        else if (k > a)
        {
            Console.WriteLine("Загаданное число меньше.");
        }
        else
        {
            Console.WriteLine("Поздравляю! Вы угадали число.");

        }
    } while (k != a);

}
task2();
//Задание 7
void task3()
{

    Random rnd = new Random();
    int[] a = new int[6];
    int z = 1000;
    int c2 = 0;
    for (int i = 0; i < z; i++)
    {

        int dnd = rnd.Next(1, 7);
        a[dnd - 1]++;

    }
    Console.WriteLine("Статистика выпадения чисел:");
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine($"Значение {i + 1} - {a[i]}");
    }
}
task3();
//Задание 8
void task3()
{

    Console.WriteLine("Введите элементы списка через пробел. Для завершения ввода введите 0:");

    List<int> numbers = new List<int>();
    string input;

    while (true)
    {
        input = Console.ReadLine();
        string[] values = input.Split(' ');

        foreach (string value in values)
        {
            if (int.TryParse(value, out int number))
            {
                if (number == 0)
                {
                    // Прерывание ввода при введении 0
                    goto ExitLoop;
                }
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }
        }
    }

ExitLoop:

    // Проверка на пустой список
    if (numbers.Count == 0)
    {
        Console.WriteLine("Список пуст. Введите хотя бы один элемент.");
        return;
    }

    // Вычисление среднего арифметического
    double average = numbers.Average();

    // Поиск индекса элемента, ближайшего к среднему арифметическому
    int closestIndex = -1;
    double closestDifference = double.MaxValue;

    for (int i = 0; i < numbers.Count; i++)
    {
        double difference = Math.Abs(numbers[i] - average);
        if (difference < closestDifference)
        {
            closestDifference = difference;
            closestIndex = i;
        }
    }

    // Вывод результата
    Console.WriteLine($"Заданный список: [{string.Join(", ", numbers)}]");
    Console.WriteLine($"Среднее арифметическое: {average}");
    Console.WriteLine($"Индекс элемента, ближайшего к среднему: {closestIndex}");
}
task3();
//Задание 9
using System;
using System.Collections.Generic;

class Program
{
    static void Main()

    {
        Console.WriteLine("Введите число N");
        int h = Convert.ToInt32(Console.ReadLine());
        int limit = h; // Установите предел до которого нужно найти простые числа
        List<int> primes = SieveOfAtkin(limit);

        Console.WriteLine("Простые числа до " + limit + ":");
        foreach (int prime in primes)
        {
            Console.Write(prime + " ");
        }
    }

    static List<int> SieveOfAtkin(int limit)
    {
        if (limit < 2) return new List<int>();
        if (limit < 3) return new List<int> { 2 };

        bool[] isPrime = new bool[limit + 1];
        for (int i = 0; i <= limit; i++)
        {
            isPrime[i] = false;
        }

        isPrime[2] = true;
        isPrime[3] = true;

        for (int x = 1; x * x <= limit; x++)
        {
            for (int y = 1; y * y <= limit; y++)
            {
                int n = 4 * x * x + y * y;
                if (n <= limit && (n % 12 == 1 || n % 12 == 5))
                {
                    isPrime[n] = !isPrime[n];
                }

                n = 3 * x * x + y * y;
                if (n <= limit && n % 12 == 7)
                {
                    isPrime[n] = !isPrime[n];
                }

                n = 3 * x * x - y * y;
                if (x > y && n <= limit && n % 12 == 11)
                {
                    isPrime[n] = !isPrime[n];
                }
            }
        }

        for (int r = 5; r * r <= limit; r++)
        {
            if (isPrime[r])
            {
                for (int i = r * r; i <= limit; i += r * r)
                {
                    isPrime[i] = false;
                }
            }
        }

        List<int> primes = new List<int>();
        for (int i = 2; i <= limit; i++)
        {
            if (isPrime[i])
            {
                primes.Add(i);
            }
        }

        return primes;
    }
}
//задание 10
using System;
using System.Collections.Generic;

//int l = 0;
Random Random = new Random();
for (int a = 1; a < 6; a++)
{
    int l = number(a);
    Console.WriteLine("Введите ответ на задачу:");
    int g = Convert.ToInt32(Console.ReadLine());
    if (g == l) { Console.WriteLine("Ответ правильный!"); } else { Console.WriteLine($"Ответ не правильный, правильный ={l}"); }
}
static int number(int a)
{
    string p = "";
    int l = 0;
    Random Random = new Random();
    int z = Random.Next(1, 11);
    int x = Random.Next(1, 11);
    string ex;
    switch (a)
    {
        case 1:
            p = "+"; l = x + z;
            break;
        case 2:
            p = "-"; l = x - z;
            break;
        case 3:
            p = "*"; l = x * z;
            break;
        case 4:
            p = "/"; l = x / z;
            break;
        case 5:
            p = "%"; l = x % z;
            break;
    }
    ex = $"{z}{p}{x}";
    Console.WriteLine(ex);
    return l;
}
//Задание 11
using System;
using System.Collections.Generic;
using System;

class Program
{
    static void Main()
    {
        // Входные данные
        double initialSum = 8000; // Начальная сумма
        double annualRate = 15; // Процентная ставка (в годовых)
        Console.WriteLine("Введите количество месяцев");
        int months = Convert.ToInt32(Console.ReadLine());
        // Переводим процентную ставку в десятичный вид
        double monthlyRate = annualRate / 12 / 100;

        // Вычисляем сумму на конец каждого месяца
        for (int i = 1; i <= months; i++)
        {
            double sum = initialSum * Math.Pow(1 + monthlyRate, i);
            Console.WriteLine($"{i} месяц: {sum:F6}");
        }
    }
}
//Задание 12
using System;
using System.Collections.Generic;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение n!");
        int z = Convert.ToInt32(Console.ReadLine());
        int factor = fac(z);
        Console.WriteLine($"Факториал числа = {factor}");
        int fac(int n)
        {
            if (n == 1) return 1;
            return n * fac(n - 1);
        }
    }
}
