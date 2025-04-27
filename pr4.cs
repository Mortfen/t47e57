//Задание 1
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение ");
        int z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение для удаления ");
        int f = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Итог: ");
        List<int> z1 = Remo(z);
        for (int i = 0; i < z1.Count; i++)
        { if (z1[i] == f) { z1.Remove(i); } else { Console.WriteLine(z1[i]); } }
        static List<int> Remo(int z)
        {
            List<int> revo = new List<int>();
            string a = z.ToString();
            foreach (char revoChar in a) { revo.Add(int.Parse(revoChar.ToString())); }
            return revo;
        }
    }
}
//Задание 2
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
class Program
{
    public static int t;
    public static int z;
    public static List<string> fam = new List<string>() { "Мосин", "Гаврилов", "Козин", "Джугашвили", };
    public static List<int> mat = new List<int>();
    public static List<int> bio = new List<int>();
    public static List<int> lit = new List<int>();
    public static Random z1h1 = new Random();
    static void Main()
    {

        for (int i = 0; i < 5; i++)
        {
            mat.Add(z1h1.Next(2, 5));
            bio.Add(z1h1.Next(2, 5));
            lit.Add(z1h1.Next(2, 5));
        }
        do
        {
            Console.WriteLine("Что делать?");
            Console.WriteLine("1-вывести оценки по фамилии");
            Console.WriteLine("2-Студентов по оценке");
            z = Convert.ToInt32(Console.ReadLine());
            if (z == 1)
            {
                Console.WriteLine("Выбирите фамилию:");
                Console.WriteLine($"1 - {fam[0]} ");
                Console.WriteLine($"2 - {fam[1]} ");
                Console.WriteLine($"3 - {fam[2]} ");
                Console.WriteLine($"4 - {fam[3]} ");
                int t = Convert.ToInt32(Console.ReadLine());
                F.num1(t, fam, mat, bio, lit);
            }
            if (z == 2)
            {
                Console.WriteLine("Выбирите предмет:");
                Console.WriteLine("1 - Математика:");
                Console.WriteLine("2 - Биология:");
                Console.WriteLine("3 - Литература:");
                int z = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Выбирите отценку от 2 до 5:");
                int o = Convert.ToInt32(Console.ReadLine());
                if (o < 2 || o > 5) { break; }
                F.d1(z, o, fam, mat, bio, lit);
            }
        }

        while (z != 0);
    }

}
//Задание 3
using System;
using System.Collections.Generic;
using ScottPlot;
using OxyPlot;
using OxyPlot.Series;

class program
{
    public static double dev;
    public static double SRED;
    public static double max;
    public static List<int> a = new List<int>(new int[7]);
    public static List<int> b = new List<int>(new int[7]);
    public static List<int> c = new List<int>(new int[7]);
    public static List<int> d = new List<int>(new int[7]);
    public static List<double> h1z1 = new List<double>(new double[7]);
    static void Main()

    {
        F.rnd(a, b, c, d);
        F.print(a);
        F.print(b);
        F.print(c);
        F.print(d);
        max = F.absmax(a, b, h1z1, max);
        Console.WriteLine("Макс.абс. отклонения 1 и 2 списка:");
        Console.WriteLine(max);
        SRED = F.abssred(h1z1, SRED);
        Console.WriteLine("Сред.абс. отклонения 1 и 2 списка:");
        Console.WriteLine(SRED);
        max = F.absmax(a, c, h1z1, max);
        Console.WriteLine("Макс.абс. отклонения 1 и 3 списка:");
        Console.WriteLine(max);
        SRED = F.abssred(h1z1, SRED);
        Console.WriteLine("Сред.абс. отклонения 1 и 3 списка:");
        Console.WriteLine(SRED);
        max = F.absmax(a, d, h1z1, max);
        Console.WriteLine("Макс.абс. отклонения 1 и 4 списка:");
        Console.WriteLine(max);
        SRED = F.abssred(h1z1, SRED);
        Console.WriteLine("Сред.абс. отклонения 1 и 4 списка:");
        Console.WriteLine(SRED);
        Console.WriteLine("отклонения 1 и 2 списка:");
        List<double> a1 = F.Calc(a, b);
        F.Graph(a1);
        Console.WriteLine("отклонения 1 и 3 списка:");
        List<double> a2 = F.Calc(a, c);
        F.Graph(a1);
        Console.WriteLine("отклонения 1 и 4 списка:");
        List<double> a3 = F.Calc(a, d);
        F.Graph(a1);

    }
}
//Задание 4
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите время в секундах:");
        if (int.TryParse(Console.ReadLine(), out int Seconds))
        {
            StartTimer(Seconds);
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }
    }

    static void StartTimer(int totalSeconds)
    {
        int remainingSeconds = totalSeconds;
        Console.CursorVisible = false; // Скрыть курсор

        while (remainingSeconds > 0)
        {
            Console.Beep();
            // Вычисление минут и секунд
            int minutes = remainingSeconds / 60;
            int seconds = remainingSeconds % 60;

            // Отображение времени
            Console.Clear();
            Console.ForegroundColor = color(remainingSeconds, totalSeconds);
            Console.WriteLine($"Осталось: {minutes:D2}:{seconds:D2}");

            // Задержка в 1 секунду
            Thread.Sleep(1000);
            remainingSeconds--;
        }

        // Звуковой сигнал при завершении
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Время истекло!");
        Console.CursorVisible = true; // Восстановить курсор
    }

    static ConsoleColor color(int remainingSeconds, int Seconds)
    {
        // Цветовая индикация прогресса
        if (remainingSeconds >= Seconds * 0.66)
            return ConsoleColor.Green; // Зеленый (более 66%)
        if (remainingSeconds >= Seconds * 0.33)
            return ConsoleColor.Yellow; // Желтый (от 33% до 66%)
        return ConsoleColor.Red; // Красный (менее 33%)
    }
}
