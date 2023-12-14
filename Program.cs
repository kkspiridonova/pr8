using System.Diagnostics;

namespace Скоропечатание
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя:");

            Rating rating = new Rating();
            rating.Name = Console.ReadLine();

            Console.Clear();

           
                string Text = "Конфликтология – это наука о причинах, стратегиях, формах, структуре и динамике путях разрешения конфликтов.";
                Console.WriteLine(Text);

                Console.SetCursorPosition(0, 4);
                Console.WriteLine("Нажмите Enter, чтобы продолжить.");

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Stopwatch sw = new Stopwatch();
                    Thread timer = new Thread(() =>
                    {
                        while (sw.Elapsed.TotalSeconds <= 59)
                        {
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(0, 15);
                            sw.Start();
                            Console.WriteLine($@"{sw.Elapsed.Minutes}:{sw.Elapsed.Seconds}");

                        }
                    });
                    timer.Start();

                    Typing test = new Typing();
                    test.Test(Text);

                    Console.ResetColor();
                    Console.WriteLine("Конец теста");

              


            }
            
        } 

                
           
       
    }
}