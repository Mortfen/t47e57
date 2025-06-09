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
            n = F.quick(s);
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
        myPLOT.SavePng("quck.png", 400, 300);






    }
}
using System;

public class Character
{
    private int x; // Координата X
    private int y; // Координата Y

    // Конструктор класса
    public Character(int initialX, int initialY)
    {
        x = initialX;
        y = initialY;
    }

    // Метод движения вверх
    public void MoveUp()
    {
        if (y < 7)
            y++;
        else
            Console.WriteLine("Нельзя двигаться дальше вверх");
    }

    // Метод движения вправо
    public void MoveRight()
    {
        if (x < 7)
            x++;
        else
            Console.WriteLine("Нельзя двигаться дальше вправо");
    }

    // Метод движения вниз
    public void MoveDown()
    {
        if (y > 0)
            y--;
        else
            Console.WriteLine("Нельзя двигаться дальше вниз");
    }

    // Метод движения влево
    public void MoveLeft()
    {
        if (x > 0)
            x--;
        else
            Console.WriteLine("Нельзя двигаться дальше влево");
    }

    // Метод завершения программы
    public void Exit()
    {
        Console.WriteLine("Завершение программы");
        Environment.Exit(0);
    }

    // Метод для вывода текущего положения
    public void DisplayPosition()
    {
        Console.WriteLine($"Текущее положение: X = {x}, Y = {y}");
    }

    // Метод для обработки ввода команд
    public void ProcessCommand(string command)
    {
        switch (command.ToLower())
        {
            case "вверх":
                MoveUp();
                break;
            case "вниз":
                MoveDown();
                break;
            case "влево":
                MoveLeft();
                break;
            case "вправо":
                MoveRight();
                break;
            case "конец":
                Exit();
                break;
            default:
                Console.WriteLine("Неверная команда");
                break;
        }
        DisplayPosition();
    }
}

class Program
{
    static void Main()
    {
        Character character = new Character(3, 2); // Начальное положение X: 3, Y: 2
        Console.WriteLine("Начальное положение:");
        character.DisplayPosition();

        while (true)
        {
            Console.WriteLine("Введите команду:");
            string command = Console.ReadLine();
            character.ProcessCommand(command);
        }
    }
}
//3
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


class Program
{

    public static string z ="";
    static void Main()
    {
        Console.WriteLine("Введете последовательность:");
        z = Console.ReadLine();
        StackB stack1 = new StackB(z);
        stack1.Check();
        stack1.CheckOrder();



    }

    public class StackB
    {
        private string s;

        public StackB(string a)
        {
            s = a;
    
        }
        public void CheckOrder() 
        {
            Dictionary<byte, List<byte>> f = new Dictionary<byte, List<byte>>
            {
                {40 ,new List<byte>{93,125 } },
                {91 ,new List<byte>{41,125 } } ,
                {123 ,new List<byte>{41,93 } }

            };
            byte[] n = Encoding.UTF8.GetBytes(s);
            string f1 = "";
            int y = 1;

            for (int i = 0; i < n.Length-1; i++)
            {
                byte t = n[i];
                byte t2 =n[i+1];
                if (f.TryGetValue(t, out List<byte> fB)) 
                {
                    if (fB.Contains(t2)) 
                    {
                        Console.WriteLine($"Нарушение правила после {t} , идёт недопускаемое выражение {t2}");
                    
                    
                    }
                
                
                }
            }
        }
        public void Check()
        {
            byte[] n = Encoding.UTF8.GetBytes(s);
            string f = "";
            int y = 1;

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] != 40 && n[i] != 41 && n[i] != 91 && n[i] != 93 && n[i] != 123 && n[i] != 125)
                {
                    y = 0;
                    byte[] zn = { n[i] };
                    f = Encoding.UTF8.GetString(zn);
                    Console.WriteLine($"Некорректно введенный символ ~{f}~");
                    break;
                }
            }

            if (y == 1)
            {
                Console.WriteLine("Все символы соответствуют алфавиту.");
            }
        }
    }




} 
//4
using System;

class Program
{
    static void Main()
    {
        // Запрос количества рядов и мест в каждом ряду
        Console.WriteLine("Введите количество рядов в кинотеатре:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество мест в каждом ряду:");
        int m = int.Parse(Console.ReadLine());

        // Создание и заполнение массива случайными значениями
        int[,] cinemaHall = new int[n, m];
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                cinemaHall[i, j] = random.Next(2); // Случайное значение 0 или 1
            }
        }

        // Вывод текущей картины зала
        Console.WriteLine("Текущая картина зала:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(cinemaHall[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Запрос количества билетов
        Console.WriteLine("Введите количество билетов, которые хотите приобрести:");
        int k = int.Parse(Console.ReadLine());

        // Поиск рядов с достаточным количеством свободных мест подряд
        bool found = false;
        Console.WriteLine("Ряды, в которых можно приобрести билеты:");

        for (int i = 0; i < n; i++)
        {
            int consecutiveFreeSeats = 0;
            for (int j = 0; j < m; j++)
            {
                if (cinemaHall[i, j] == 0)
                {
                    consecutiveFreeSeats++;
                    if (consecutiveFreeSeats == k)
                    {
                        Console.WriteLine(i + 1); // Номера рядов начинаются с 1
                        found = true;
                        break;
                    }
                }
                else
                {
                    consecutiveFreeSeats = 0;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("Нет рядов с достаточным количеством свободных мест подряд.");
        }
    }
}
