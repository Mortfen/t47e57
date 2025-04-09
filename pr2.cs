//задание 1
void task1()
{
    Console.Write("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());
    int c = a % 2;
    if (c == 0) { Console.WriteLine("Число чётное"); }
    else { Console.WriteLine("Число нечётное"); }

}
task1();
//задание 2
void task2()
{
    Console.WriteLine("Введите числа");
    double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    if (a > b) { Console.WriteLine($"Большее {a}"); }
    else if (a < b) { Console.WriteLine($"Большее {b}"); }
    else { Console.WriteLine("Это одинаковые числа"); }

}
task2();
//задание 3
void task3()
{

    Console.Write("Введите коэффициент a: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите коэффициент b: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите коэффициент c: ");
    double c = Convert.ToDouble(Console.ReadLine());

    double d = b * b - 4 * a * c;

    if (d > 0)
    {
        double x1 = (-b + Math.Sqrt(d)) / (2 * a);
        double x2 = (-b - Math.Sqrt(d)) / (2 * a);
        Console.WriteLine($"Уравнение имеет два различных корня {x1} и {x2}");
    }
    else if (d == 0)
    {
        double x = -b / (2 * a);
        Console.WriteLine($"Уравнение имеет один действительный корень {x} ");
    }
    else
    {

        Console.WriteLine("Уравнение не имеет корней.");

    }

}
task3();
//задание 4
using System.Threading.Tasks;

task4();
void task4()
{
    Console.Write("Введите рост: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите вес b: ");
    double b = Convert.ToDouble(Console.ReadLine());
    a = a / 100;
    double imt = b / (a * a);
    if (imt < 16) { Console.Write("Дифицит массы"); }
    else if (imt > 16 & imt < 18.5) { Console.Write("Недостаточная масса тела"); }
    else if (imt > 18.5 & imt < 25) { Console.Write("Норма"); }
    else if (imt > 25 & imt < 30) { Console.Write("Избыточная масса"); }
    else if (imt > 30 & imt < 35) { Console.Write("Ожирение 1"); }
    else if (imt > 35 & imt < 40) { Console.Write("Ожирение 2"); }
    else
    {
        Console.Write("Ожирение 3");
    }
}
//задание 5
using System.Threading.Tasks;

task5();
void task5()
{
    Console.Write("Введите сторону 1: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите сторону 2: ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите сторону 3: ");
    double c = Convert.ToDouble(Console.ReadLine());
    int i = 0;
    if (a < (b + c)) { i++; }
    if (b < (c + a)) { i++; }
    if (c < (a + b)) { i++; }
    if (i == 3) { Console.Write("Треугольник существует"); }
    else { Console.Write("Треугольник не существует"); }
}
//задание 6
using System.Threading.Tasks;

task6();
void task6()
{
    Console.Write("Введите координату 1: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату 2: ");
    double b = Convert.ToDouble(Console.ReadLine());
    if (a > 0 & b > 0) { Console.Write("Точка находится в 1 четверти: "); }
    else if (a < 0 & b < 0) { Console.Write("Точка находится в 3 четверти:"); }
    else if (a < 0 & b > 0) { Console.Write("Точка находится в 2 четверти:"); }
    else { Console.Write("Точка находится в 4 четверти:"); }
}
//задание 7
using System.Threading.Tasks;

task7();
void task7()
{
    Console.Write("Введите номер месяца: ");
    double a = Convert.ToDouble(Console.ReadLine());
    string s;
    switch (a)
    {
        case 12:
        case 1:
        case 2:
            s = "Зима";
            break;
        case 3:
        case 4:
        case 5:
            s = "Весна";
            break;
        case 6:
        case 7:
        case 8:
            s = "Лето";
            break;
        case 9:
        case 10:
        case 11:
            s = "Осень";
            break;
        default:
            s = "Некорректный номер месяца";
            break;
    }
    int d;
    switch (a)
    {
        case 2:
            d = 28; // Февраль в невисокосном году
            break;
        case 4:
        case 6:
        case 9:
        case 11:
            d = 30;
            break;
        default:
            d = 31;
            break;
    }

    Console.Write($"{d} - количсетво дней, {s} ");
}
//задание 8
using System.Threading.Tasks;

task7();
void task7()
{
    Console.Write("Введите M: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите N: ");
    double s = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите K: ");
    double k = Convert.ToDouble(Console.ReadLine());
    double z = 0.5 * a * s;
    if (z % k == 0)
    { Console.WriteLine("YES"); }
    else { Console.WriteLine("NO"); }

}
//задание 9
using System.Threading.Tasks;

task7();
void task7()
{
    Console.Write("Введите x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    int x1 = x + 1;
    int y1 = y + 2;
    int x2 = x - 1;
    int y2 = y + 2;
    int x3 = x - 1;
    int y3 = y - 2;
    int x4 = x + 1;
    int y4 = y - 2;
    int x5 = x + 2;
    int y5 = y - 1;
    int x6 = x + 2;
    int y6 = y + 1;
    int x7 = x - 2;
    int y7 = y + 1;
    int x8 = x - 2;
    int y8 = y - 1;
    if (a == x1 || a == x2 || a == x3 || a == x4 || a == x5 || a == x6 || a == x7 || a == x8) { i++; }
    if (b == y1 || b == y2 || b == y3 || b == y4 || b == y5 || b == y6 || b == y7 || b == y8) { i++; }
    if (i == 2) { Console.Write("Yes"); } else { Console.WriteLine("NO"); }
}
