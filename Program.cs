namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write($"Введите диапозон загадываемого числа. От 1 до....: ");
            int n = int.Parse(Console.ReadLine()); // Диапазон

            Console.Write($"Введите количество попыток: ");
            int count_attempts = int.Parse(Console.ReadLine()); // Количество попыток
            int hidden_number = rnd.Next(1, n); // Генерация отгадываемого числа
            for (int i = 0; i < count_attempts; i++)
            {
                Console.Write($"Введите загаданное число: ");
                int try_to_guessing = int.Parse(Console.ReadLine()); // Попытка угадать число

                if (try_to_guessing < hidden_number)
                {
                    Console.WriteLine($"Загаданное число больше!");
                }

                else if (try_to_guessing > hidden_number)
                {
                    Console.WriteLine($" Загаданное число меньше! ");
                }

                else
                {
                    Console.WriteLine($" Ура! Вы угадали число! ");
                    break;
                }

                if (i == count_attempts - 1)
                {
                    Console.WriteLine($" Попытки закончились! ");
                }
            }
        }
    }
}

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write($"Введите количество элементов массива: ");

            int Dimension_Of_The_Array = int.Parse(Console.ReadLine());
            int[] Array = new int[Dimension_Of_The_Array]; // Изначальный массив
            for (int i = 0; i < Dimension_Of_The_Array; i++) // Заполнение массива случайными числами
            {
                Array[i] = rand.Next(-100, 100);
                Console.Write($"{Array[i]}\t");
            }

            Console.WriteLine($"");
            Random random = new Random();
            int randd;
            for (int i = 0; i < Dimension_Of_The_Array; i++)
            {
                int Buffer = Array[i];
                randd = random.Next(i, Dimension_Of_The_Array);
                Array[i] = Array[randd];
                Array[randd] = Buffer;
            }
            Console.WriteLine($"Перемешанный массив:");
            for (int i = 0; i < Dimension_Of_The_Array; i++)
            {
                Console.Write($"{Array[i]}\t");
            }
            Console.WriteLine($"");
        }
    }
}

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int S11; // Максимальная площадь
            Console.Write("Введите площадь треугольника: ");
            S11 = int.Parse(Console.ReadLine());

            int S22 = 0; // Для треугольников, которых нет
            for (int S = 1; S <= S11; S++)
            {
                int a1 = 0, b1 = 0, c1 = 0, a2 = 0, b2 = 0, c2 = 0, a3 = 0, b3 = 0, c3 = 0; // Стороны искомых треугольников
                int CheckNumber = 0; // Существующие треугольники
                for (int a = 1; a <= S; a++) // Проверка по стороне а
                {
                    for (int b = 1; b <= S; b++) // Проверка по стороне б
                    {
                        if ((a * b / 2) == S) // Площадь треугольника
                        {
                            for (int c = 1; c < a + b; c++) // Проверка по стороне с
                            {
                                if (a * a + b * b == c * c) // Проверка существования треугольника
                                {
                                    if (CheckNumber == 2)
                                    {
                                        a3 = a; b3 = b; c3 = c; S22 = 1;
                                        Console.Write($"a = {a1} b = {b1} c = {c1} \n");
                                        Console.Write($"a = {a2} b = {b2} c = {c2} \n");
                                        Console.WriteLine($"a = {a3} b = {b3} c = {c3}");
                                        Console.Write($"Площадь этих трехтреугольников = { S} \n");
                                    }
                                    if (CheckNumber == 1) { a2 = a; b2 = b; c2 = c; CheckNumber = 2; }
                                    if (CheckNumber == 0) { a1 = a; b1 = b; c1 = c; CheckNumber = 1; }
                                }
                            }
                        }
                    }
                }
            }
            if (S22 == 0) Console.WriteLine($"Трёх таких треугольников не существует");
            Console.ReadLine();
        }
    }
}

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите количество участников деления яблок: ");
            int Count_Of_Human = int.Parse(Console.ReadLine()); // Количество человек

            Console.WriteLine($"Введите количество сорванных яблок: ");
            int Y = int.Parse(Console.ReadLine()); // Используется для количества строк

            int[] apple = new int[Count_Of_Human]; // Количество яблок у каждого человека
            for (int i = 0; i < Count_Of_Human; i++)
            {
                apple[i] = 0;
            }
            apple[0] = Y;
            for (int i = 0; i < Count_Of_Human; i++) // Деление яблок
            {
                int ya = apple[i]; // Количество яблок до деления
                apple[i] = ya % (Count_Of_Human - 1);
                for (int j = 0; j < Count_Of_Human; j++)
                {
                    if (j != i) // Участник, отдающий яблоки, яблоки не получает
                        apple[j] = apple[j] + ((ya - apple[i]) / (Count_Of_Human - 1));
                }
            }
            for (int i = 0; i < Count_Of_Human; i++)
            {
                Console.WriteLine($"Количество яблок у {i + 1} участника = {apple[i]} ");
            }
        }
    }
}

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Введите год: ");
        int Year = int.Parse(Console.ReadLine());

        Console.Write("Введите месяц: ");
        int Month = int.Parse(Console.ReadLine());

        Console.Write("Введите день: ");
        int Day = int.Parse(Console.ReadLine());

        var Julian_Calendar = new DateTime(Year, Month, Day);
        var Gregorian_Calendar = Julian_Calendar.AddDays((Year / 100) - ((Year / 100) / 4) - 2);

        Console.WriteLine($"По григорианскому календарю – {Gregorian_Calendar}");
        Console.WriteLine($"По юлианскому календарю – {Julian_Calendar}");
        }
    }
}


//1
int S = int.Parse(Console.ReadLine());
int V = int.Parse(Console.ReadLine());

int H = V / S;
Console.WriteLine(H);

//2

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if (a < 3)
{
    Console.Error.WriteLine(a);
}
if (b < 3)
{
    Console.Error.WriteLine(b);
}

if (c < 3)
{
    Console.Error.WriteLine(c);
}


//3

int N = int.Parse(Console.ReadLine());
int count = 0;
int[] mass = new int[N];

for (int i = 0; i < N; i++)
{
    mass[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < N; i++)
{
    if (mass[i] / 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(count);

//4 zadanie

int leviy = int.Parse(Console.ReadLine() ?? "");
int praviy = int.Parse(Console.ReadLine() ?? "");
int y;
for (int i = leviy; i <= praviy; i++)
{
    Console.WriteLine($"x = {i}");
    y = i * 2 + 3 * i - 17;
    Console.WriteLine($"y = {y}\n");
}

//5zadanie

int n = 0, s = 0, a = 1;
while (a != 0)
{
    Console.Write("Введите целое число: ");
    a = Convert.ToInt32(Console.ReadLine());
    n++;
}
Console.WriteLine("Всего чисел = {1}", s, n);


//6 zadanie

int a1 = int.Parse(Console.ReadLine() ?? "");
int b1 = int.Parse(Console.ReadLine() ?? "");
int c1 = int.Parse(Console.ReadLine() ?? "");

for (int i = a1; i <= b1; i++)
{
    if (i % c1 == 0)
    {
        Console.WriteLine($"{i}");
    }
}