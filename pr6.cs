using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ScottPlot;

class Program
{

    public static List<int> s = new List<int>();
    public static List<int> p = new List<int>();
    public static List<int> k = new List<int>();

    public static int t = 0;
    public static long n = 0;
    static void Main()
    {

        Random rnd = new Random();
        Console.WriteLine("Ввидите нижнюю и верхнюю границу списка");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        for (int z = 100; z <= 1500; z += 200)
        {
            s = F.rnd(x, y, z);
            n = F.Bubble(s);
            F.print(s, z);
            Console.WriteLine($"!{n} - мс Время выполнения сортировки");
            p.Add(z);
            k.Add(Convert.ToInt32(n));
        }
        F.print(p, 8);
        F.print(k, 8);
        ScottPlot.Plot myPLOT = new();
        myPLOT.Add.Scatter(p, k);
        myPLOT.SavePng("booble", 400, 300);






    }
}
//2
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ScottPlot;

class Program
{

    public static List<int> s = new List<int>();
    public static List<int> p = new List<int>();
    public static List<int> k = new List<int>();

    public static int t = 0;
    public static long n = 0;
    static void Main()
    {

        Random rnd = new Random();
        Console.WriteLine("Ввидите нижнюю и верхнюю границу списка");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        for (int z = 100; z <= 1500; z += 200)
        {
            s = F.rnd(x, y, z);
            n = F.ins(s);
            F.print(s, z);
            Console.WriteLine($"!{n} - мс Время выполнения сортировки");
            p.Add(z);
            k.Add(Convert.ToInt32(n));
            s.Clear();
            if (s.Count == 0)
            {
                Console.WriteLine("В списке ничего нет.");
            }
        }
        F.print(p, 8);
        F.print(k, 8);
        ScottPlot.Plot myPLOT = new();
        myPLOT.Add.Scatter(p, k);
        myPLOT.SavePng("booble.png", 400, 300);






    }
}
//3
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ScottPlot;

class Program
{
    public static List<long> s1 = new List<long>();
    public static List<int> s = new List<int>();
    public static List<int> p = new List<int>();
    public static List<int> k = new List<int>();

    public static int t = 0;
    public static long n = 0;
    static void Main()
    {

        Random rnd = new Random();
        Console.WriteLine("Ввидите нижнюю и верхнюю границу списка");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ввидите длину последовательности");
        int z = Convert.ToInt32(Console.ReadLine());
        s = F.rnd(x, y, z);
        F.Bubble(s);
        F.print(s, z);
        Console.WriteLine("Введите необходимое значние");
        int targetlock = Convert.ToInt32(Console.ReadLine());
        F.binsearch(s, targetlock);

        //ScottPlot.Plot myPLOT = new();
        //myPLOT.Add.Scatter(p,k);
        //myPLOT.SavePng("booble.png", 400, 300);






    }
}
//4
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число n:");
        int n = int.Parse(Console.ReadLine()); // Ввод числа n с клавиатуры

        double sum = CalculateSum(n);
        Console.WriteLine($"Сумма ряда: {sum}");
    }

    static double CalculateSum(int n)
    {
        if (n < 0)
        {
            return 0;
        }

        double term = Math.Pow(-1, n) / Math.Pow(n + 1, n);
        return term + CalculateSum(n - 1);
    }
}