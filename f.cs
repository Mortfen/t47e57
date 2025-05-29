using System;
using ScottPlot;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using OxyPlot;
using OxyPlot.Series;


public static class F
{
    public static void num1(int b, List<string> fam, List<int> mat, List<int> bio, List<int> lit)
    {
        if (b == 1) { Console.WriteLine($"Имя - {fam[0]}, оценки: Математика - {mat[0]}, Биология - {bio[0]}, Литература - {lit[0]}"); }
        if (b == 2) { Console.WriteLine($"Имя - {fam[1]}, оценки: Математика - {mat[1]}, Биология - {bio[1]}, Литература - {lit[1]}"); }
        if (b == 3) { Console.WriteLine($"Имя - {fam[2]}, оценки: Математика - {mat[2]}, Биология - {bio[2]}, Литература - {lit[2]}"); }
        if (b == 4) { Console.WriteLine($"Имя - {fam[3]}, оценки: Математика - {mat[3]}, Биология - {bio[3]}, Литература - {lit[3]}"); }
    }
    public static void d1(int b, int a, List<string> fam, List<int> mat, List<int> bio, List<int> lit)
    {
        if (b == 1) { for (int i = 0; i < 5; i++) { if (mat[i] == a) { Console.WriteLine($"Оценка по математике {a} у: {fam[i - 1]}"); } } }
        if (b == 2) { for (int i = 0; i < 5; i++) { if (bio[i] == a) { Console.WriteLine($"Оценка по биологи {a} у: {fam[i - 1]}"); } } }
        if (b == 3) { for (int i = 0; i < 5; i++) { if (lit[i] == a) { Console.WriteLine($"Оценка по литературе {a} у: {fam[i - 1]}"); } } }
    }
    public static void rnd(List<int> a, List<int> b, List<int> c, List<int> d)
    {
        Random rnd = new Random();
        for (int i = 0; i < 7; i++)
        {
            a[i] = rnd.Next(1, 10);
            b[i] = rnd.Next(1, 10);
            c[i] = rnd.Next(1, 10);
            d[i] = rnd.Next(1, 10);


        }
    }
    public static void print(List<int> a)
    {
        Console.Write($" Массив - ");
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"{a[i]} ");


        }

    }
    public static void print2(List<double> a)
    {
        Console.Write($" Массив - ");
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"{a[i]} ");


        }

    }
    public static double absmax(List<int> a, List<int> b, List<double> h1z1, double max)
    {
        Console.WriteLine("");
        //Console.WriteLine("Абсолютное отклонение:");
        // Вычисление абсолютных отклонений
        for (int i = 0; i < a.Count; i++)
        {
            // Вычисление абсолютного значения вручную
            int difference = a[i] - b[i];
            double z = (difference >= 0) ? difference : -difference;

            h1z1[i] = z;
            // Console.WriteLine(h1z1[i]);
        }
        max = h1z1[0];
        for (int i = 1; i < h1z1.Count; i++)
        {
            if (h1z1[i] > max)
            {
                max = h1z1[i];
            }
        }
        return max;
    }


    public static double abssred(List<double> h1z1, double SRED)
    {
        {
            double sum = 0;
            int l = 0;
            for (int i = 0; i < 7; i++) { sum = sum + h1z1[i]; l++; }
            SRED = sum / l;
        }
        return SRED;

    }

    public static List<double> Calc(List<int> a, List<int> b)
    {
        List<double> dev = new List<double>();
        // Вычисление абсолютных отклонений
        for (int i = 0; i < a.Count; i++)
        {
            int difference = a[i] - b[i];
            double absoluteDifference = (difference >= 0) ? difference : -difference;
            dev.Add(absoluteDifference);
        }

        return dev;
    }
    public static void Graph(List<double> data)
    {
        // Найти максимальное значение для масштабирования
        double maxValue = data.Count > 0 ? data.Max() : 1;

        // Построение графика
        for (int i = 0; i < data.Count; i++)
        {
            // Вычисление высоты столбца на основе значения
            int barHeight = (int)(data[i] / maxValue * 10);
            Console.Write($"{i + 1}: ");
            for (int j = 0; j < barHeight; j++)
            {
                Console.Write('#');
            }
            Console.WriteLine();
        }
    }

}
    public static string alpha(string text, int shift) 
    {
    
        StringBuilder sb = new StringBuilder();
        foreach (char c in text) 
        {
            if (Array.IndexOf(russianAlphabet, c) != -1)
            {
                int index = Array.IndexOf(russianAlphabet, c);
                int n = (index + shift) % russianAlphabet.Length;
                sb.Append(russianAlphabet[n]);
            }
            else { sb.Append(c); }
            
            
        }
        
        return sb.ToString();
    }
    public static string enc(string text, int s) 
    { return alpha(text, russianAlphabet.Length - s); }


 public static long Bubble(List<int> list)
   {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int n = list.Count;
        for (int i = 1; i < n ; i++)
        {
            for (int j = 0; j < n - i; j++)
            {
                if (list[j] > list[j + 1])
                {
                    // Меняем элементы местами
                    int temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
        
        stopwatch.Stop();
        long z = stopwatch.ElapsedMilliseconds;
        return z;
   }
   public static long ins(List<int> a)
    { 
       
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 1; i <a.Count; i++) 
        {
           int index = a[i];
           int j = i-1;
            while (j >= 0 && a[j]> index)
            { a[j + 1] = a[j]; j--;}
            a[j+1]=index;
        }
        stopwatch.Stop ();
        long z = stopwatch.ElapsedMilliseconds;
        return z;
    
    
    }
}

    




    public static int binsearch(list<int> z, int target)
    {
        int l=0;
        int r=z.count;
        while(r>=l)
        {
            int mid =l+(r-l)/2;
            if(z[mid]<target) {l=mid; for(int i=l;l>=r;l++){Console.Write($"z[l]")}}
            else if(z[mid]>target) {r=mid; for(int i=l;l>=r;l++){Console.Write($"z[l]")}}
            if (z[mid]== target){//////}
            
        }



        
    }

}

