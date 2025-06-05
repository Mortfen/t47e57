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
