using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

public static class F
{
    public static void num1(int b, List<string> fam, List<int> mat, List<int> bio, List<int> lit)
    {
        if (b == 1) { Console.WriteLine($"Имя - {fam[0]}, оценки: Математика - {mat[0]}, Биология - {bio[0]}, Литература - {lit[0]}"); }
        if (b == 2) { Console.WriteLine($"Имя - {fam[1]}, оценки: Математика - {mat[1]}, Биология - {bio[1]}, Литература - {lit[1]}"); }
        if (b == 3) { Console.WriteLine($"Имя - {fam[2]}, оценки: Математика - {mat[2]}, Биология - {bio[2]}, Литература - {lit[2]}"); }
        if (b == 4) { Console.WriteLine($"Имя - {fam[3]}, оценки: Математика - {mat[3]}, Биология - {bio[3]}, Литература - {lit[3]}"); }
    }
    public static void d1(int b,int a, List<string> fam, List<int> mat, List<int> bio, List<int> lit) 
    {
        if (b == 1) { for (int i = 0; i < 5; i++) { if (mat[i] == a) { Console.WriteLine($"Оценка по математике {a} у: {fam[i-1]}"); } } }
        if (b == 2) { for (int i = 0; i < 5; i++) { if (bio[i] == a) { Console.WriteLine($"Оценка по биологи {a} у: {fam[i-1]}"); } } }
        if (b == 3) { for (int i = 0; i < 5; i++) { if (lit[i] == a) { Console.WriteLine($"Оценка по литературе {a} у: {fam[i - 1]}"); } } }
    }
}
