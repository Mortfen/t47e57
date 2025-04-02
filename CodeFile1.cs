
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
    int h = m / 10;//сколько каждому достанется монет
    Console.WriteLine($"Каждому достанется: {h}");
    m = m - ((n * h) + (a * h));
    Console.WriteLine($"Останется монет: {m}");
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
void task2()
{
    Console.WriteLine("Задание 2 введите кол-во учеников в 1 классе:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите кол-во учеников в 2 классе:");
    int z = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите кол-во учеников в 3 классе:");
    int x = Convert.ToInt32(Console.ReadLine());
    double y = a + z + x;
    y = y / 2;
    double f = y - (int)y;//находим остаток
    f = 1 - f;
    double p = f + y;
    Console.WriteLine($"Кол-во парт {p}");
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
void task55()
{
    Console.WriteLine("Задание 5 введите радиус круга:");
    double z = Convert.ToDouble(Console.ReadLine());
    double s = Math.Pow(z, 2) * Math.PI;
    Console.WriteLine($"Площадь равна: {s}");
}

task55();
