
//Задание 4
void task4()
{
    Console.WriteLine("Задание 4, введите 5-значное число:");
    int a = Convert.ToInt32(Console.ReadLine());
    int sum = a % 10;
    int it = 0;
    it = it + sum;
    Console.WriteLine(sum);
    sum = (a % 100) / 10;
    it = it + sum;
    Console.WriteLine(sum);
    sum = (a % 1000) / 100;
    it = it + sum;
    Console.WriteLine(sum);
    sum = (a % 10000) / 1000;
    it = it + sum;
    Console.WriteLine(sum);
    sum = (a % 100000) / 10000;
    it = it + sum;
    Console.WriteLine(sum);
    Console.WriteLine($"Сумма = {it}");
}
task4();
//Задание 5
void task5()
{
    Console.WriteLine("Задание 5, введите число:");
    int a = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    int it = a % 10;
    Console.WriteLine(it);
    sum = it * 100;
    it = (a % 100) / 10;
    sum = sum + (it * 10);
    Console.WriteLine(it);
    it = (a % 1000) / 100;
    sum = sum + it;
    Console.WriteLine(it);
    Console.WriteLine(sum);
}
task5();
//Задание 6
void task6()
{
    Console.WriteLine("Задание 6, введите число лисиц:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задание 6, введите число котов:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задание 6, введите число монет:");
    int m = Convert.ToInt32(Console.ReadLine());
    int h = a + n;//Общие количество
    int p = m / h;
    Console.WriteLine($"Каждому достанется: {p}");
    int p2 = m % h;
    Console.WriteLine($"Останется монет: {p2}");
}
task6();
//Задание 7
void task7()
{
    Console.WriteLine("Задание 7 введите 1 переменную:");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Задание введите вторую переменную:");
    double n = Convert.ToDouble(Console.ReadLine());

    double Sum(double x, double y)
    {
        return x = y;
    }
    Console.WriteLine("1-я переменная", Sum(a, n));
    Console.WriteLine("2-я переменная", Sum(n, a));
}
task7();
//Задание 7
void task77()
{
    Console.WriteLine("Задание 7 введите 1 переменную:");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Задание введите вторую переменную:");
    double n = Convert.ToDouble(Console.ReadLine());
    a = a + n;
    n = a - n;
    a = a - n;
    Console.WriteLine($"1-я переменная{a}");
    Console.WriteLine($"2-я переменная{n}");
}
task77();
//Задание 7
void task88()
{
    Console.WriteLine("Задание 7 введите 1 переменную:");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Задание введите вторую переменную:");
    double n = Convert.ToDouble(Console.ReadLine());
    (a, n) = (n, a);
    Console.WriteLine($"1-я переменная{a}");
    Console.WriteLine($"2-я переменная{n}");
}
task88();
//Задание 8
void task8()
{
    Console.WriteLine("Задание 8 введите число переменную:");
    double a = Convert.ToDouble(Console.ReadLine());
    int ss = (int)a;
    int ss1 = ss + 1;
    Console.WriteLine($"До наибольшего {ss1}");
    Console.WriteLine($"До наименьшего {ss}");
}
task8();

//Домашняя работа
//Задание 1
void task1()
{
    Console.WriteLine("Задание 1 введите 1 катет:");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("введите 2 катет:");
    double z = Convert.ToDouble(Console.ReadLine());
    double s = (a * z) / 2;
    Console.WriteLine($"Площадь = {s}");
}
task1();
//Задание 2
//парты
void task2()
{
    Console.WriteLine("Задание 2 введите кол-во учеников в 1 классе:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите кол-во учеников в 2 классе:");
    int z = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите кол-во учеников в 3 классе:");
    int x = Convert.ToInt32(Console.ReadLine());
    double y = a;
    y = y / 2;
    double o1 = Math.Ceiling(y);
    double i = z;
    i = y / 2;
    double o2 = Math.Ceiling(y);
    double i2 = x;
    i2 = y / 2;
    double o3 = Math.Ceiling(y);
    double obs = o1 + o2 + o3;
    Console.WriteLine($"Кол-во парт {obs}");
}
task2();
//Задание 3
void task3()
{
    Console.WriteLine("Задание 3 введите кол-во секунд:");
    int a = Convert.ToInt32(Console.ReadLine());
    // в часу 3600 секунд, в минуте 60
    int z = a / 3600;//кол-во часов
    int z2 = a - (z * 3600);
    int i = z2 / 60;//кол-во минут
    int i2 = z2 - (i * 60);
    Console.WriteLine($"Кол-во часов {z}");
    Console.WriteLine($"Кол-во минут {i}");
    Console.WriteLine($"Кол-во секунд {i2}");
}
task3();
//Задание 4
void task44()
{
    Console.WriteLine("Задание 4 введите кол-во секунд:");
    int a = Convert.ToInt32(Console.ReadLine());
    // в часу 3600 секунд, в минуте 60
    int z = a / 3600;//кол-во часов
    int z2 = a - (z * 3600);
    int i = z2 / 60;//кол-во минут
    int i2 = z2 - (i * 60);
    string g = $"{z:D2}";
    Console.WriteLine($"{g}:{i}:{i2}");
}
task44();
//Задание 5
void task44()
{
    Console.WriteLine("Задание 4 введите кол-во секунд:");
    int a = Convert.ToInt32(Console.ReadLine());
    // в часу 3600 секунд, в минуте 60
    int z = a / 3600;//кол-во часов
    int z2 = a - (z * 3600);
    int i = z2 / 60;//кол-во минут
    int i2 = z2 - (i * 60);
    //Console.Write(z);
    int o1 = z % 10;
    int o2 = z / 10;
    int o3 = i % 10;
    int o4 = i / 10;
    int o5 = i2 % 10;
    int o6 = i2 / 10;


    Console.Write($"{o2}{o1}:{o4}{o3}:{o6}{o5}");
}
task44();
