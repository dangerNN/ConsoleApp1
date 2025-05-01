namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введіть висоту піраміди:");
            //int height = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= height; i++)
            //{
            //    Console.WriteLine(new string(' ', height - i) + new string('*', 2 * i - 1));
            //}

            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write((i + j) % 2 == 0 ? "X " : "O ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Введіть кількість сходинок:");
            //int steps = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= steps; i++)
            //{
            //    Console.WriteLine(new string('#', i) + new string(' ', steps - i));
            //}

            //int size = 7;
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        Console.Write(i == size / 2 || j == size / 2 ? "+ " : "  ");
            //    }
            //    Console.WriteLine();
            //}

            // П'яте завдання
            //Console.CursorVisible = false;
            //int pos = 0;
            //while (!Console.KeyAvailable)
            //{
            //    Console.Clear();
            //    Console.SetCursorPosition(pos, 5);
            //    Console.Write("<Корабель>");
            //    pos = (pos + 1) % Console.WindowWidth;
            //    Thread.Sleep(100);
            //}
            //Console.CursorVisible = true;

            //int radius = 4;
            //for (int y = -radius; y <= radius; y++)
            //{
            //    for (int x = -radius; x <= radius; x++)
            //    {
            //        double distance = Math.Sqrt(x * x + y * y);
            //        Console.Write(distance <= radius ? "o " : "x ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.CursorVisible = false;
            //Random rand = new Random();
            //while (!Console.KeyAvailable)
            //{
            //    Console.Clear();
            //    for (int i = 0; i < 20; i++)
            //    {
            //        Console.SetCursorPosition(rand.Next(Console.WindowWidth),
            //                                 rand.Next(Console.WindowHeight));
            //        Console.Write("|");
            //    }
            //    Thread.Sleep(200);
            //}
            //Console.CursorVisible = true;

            Console.WriteLine("Введіть висоту трикутника:");
            int triangleHeight = int.Parse(Console.ReadLine());

            for (int i = 1; i <= triangleHeight; i++)
            {
                Console.WriteLine(new string(' ', triangleHeight - i) + new string('^', 2 * i - 1));
            }
        }
    }
}