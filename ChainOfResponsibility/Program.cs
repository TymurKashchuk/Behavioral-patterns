namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var level1 = new Level1Support();
            var level2 = new Level2Support();
            var level3 = new Level3Support();
            var level4 = new Level4Support();

            level1.SetNext(level2);
            level2.SetNext(level3);
            level3.SetNext(level4);

            while (true)
            {
                Console.WriteLine("=== Система підтримки користувачів ===");
                Console.WriteLine("Оберіть рівень проблеми:");
                Console.WriteLine("1 - Базова проблема");
                Console.WriteLine("2 - Проблема середньої складності");
                Console.WriteLine("3 - Складна проблема");
                Console.WriteLine("4 - Адміністративне питання");
                Console.Write("Ваш вибір: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                level1.HandleRequest(input);
            }
        }
    }
}
