using System;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string path = "C:/Users/mosin/source/repos/zadania/zadania/Te.txt";

        // чтение из файла
        using (FileStream fstream = File.OpenRead(path))
        {
            double d = 0;
            double s = 0;
            // выделяем массив для считывания данных из файла
            byte[] a = new byte[fstream.Length];
            // считываем данные
            await fstream.ReadAsync(a, 0, a.Length);
            //foreach (byte b in a) { Console.Write($" { b } "); }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 32) { s++; }
                else if (a[i] >= 65 && a[i] <= 90 || a[i] >= 97 && a[i] <= 122 || a[i] >= 192 && a[i] <= 255)
                { d++; }
            } // буквы и кириллица
            // декодируем байты в строку
            string text = Encoding.UTF8.GetString(a);
            Console.WriteLine($"Количество букв: {d} ");
            Console.WriteLine($"Количество слов: {s + 1}");
            Console.WriteLine($"Средняя длина слова: {(double)d / (s + 1)}");

        }
    }
}
// задание 2
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string path = "C:/Users/mosin/source/repos/zadania/zadania/Te.txt";

        // Чтение из файла
        using (FileStream fstream = File.OpenRead(path))
        {
            // Выделяем массив для считывания данных из файла
            byte[] buffer = new byte[fstream.Length];
            // Считываем данные
            await fstream.ReadAsync(buffer, 0, buffer.Length);

            // Декодируем байты в строку
            string text = Encoding.UTF8.GetString(buffer);

            // Словарь для хранения статистики по буквам
            Dictionary<char, int> s = new Dictionary<char, int>();

            // Подсчет вхождений каждой буквы
            foreach (char c in text)
            {
                if (char.IsLetter(c)) // Проверяем, является ли символ буквой
                {
                    char d = char.ToLower(c); // Приводим к нижнему регистру для унификации
                    if (s.ContainsKey(d))
                    {
                        s[d]++;
                    }
                    else
                    {
                        s[d] = 1;
                    }
                }
            }

            // Сохраняем статистику в список
            List<string> statistics = new List<string>();
            foreach (var kvp in s)
            {
                statistics.Add($"{kvp.Key}: {kvp.Value}");
            }

            // Выводим статистику на консоль
            foreach (string stat in statistics)
            {
                Console.WriteLine(stat);
            }
        }
    }
}
//Задание 3
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static StringBuilder sb;
    public static async Task Main(string[] args)
    {
        string path = "C:/Users/mosin/source/repos/zadania/zadania/Te.txt";
        string path2 = "C:/Users/mosin/source/repos/zadania/zadania/Text.txt";

        // чтение из файла
        using (FileStream fstream = File.OpenRead(path))
        {
            byte[] a = new byte[fstream.Length];
            await fstream.ReadAsync(a, 0, a.Length);
            string text = Encoding.UTF8.GetString(a);
            Console.WriteLine(text);

            do
            {
                Console.WriteLine("Что делать? 1 - Зщифровать файл 2 - Расшифровать файл");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y == 1)
                {
                    Console.WriteLine("Введите шаг");
                    int shift = Convert.ToInt32(Console.ReadLine());
                    string e = F.alpha(text, shift);
                    Console.WriteLine(e);
                    File.WriteAllText(path2, e, Encoding.UTF8);
                }
                else if (y == 2)
                {
                    Console.WriteLine("Введите шаг шифра");
                    int shift = Convert.ToInt32(Console.ReadLine());
                    using (FileStream fs = File.OpenRead(path2))
                    {
                        byte[] z = new byte[fs.Length];
                        await fstream.ReadAsync(z, 0, z.Length);
                        string text2 = Encoding.UTF8.GetString(a);
                        Console.WriteLine("Защифрованный текст");
                        Console.WriteLine(text2);
                        string g = F.enc(text2, shift);
                        Console.WriteLine("Расшифровка");
                        Console.WriteLine(g);
                    }

                }
                else { Console.BackgroundColor = ConsoleColor.Red; Console.Error.WriteLine("Ошибка"); Console.ResetColor(); }
            }
            while (true);

        }

    }
}