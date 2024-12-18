namespace DZ_4_OTUS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***************Основное задание***************
            Console.WriteLine("Основное задание:");
            Console.WriteLine();
            var s = new Stack("a", "b", "c");

            // size = 3, Top = 'c'
            Console.WriteLine($"size = {s.size}, Top = '{s.Top}'");

            var deleted = s.Pop();

            // Извлек верхний элемент 'c' Size = 2
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.size}");
            s.Add("d");

            // size = 3, Top = 'd'
            Console.WriteLine($"size = {s.size}, Top = '{s.Top}'");

            s.Pop();
            s.Pop();
            s.Pop();
            // size = 0, Top = null
            Console.WriteLine($"size = {s.size}, Top = {(s.Top == null ? "null" : s.Top)}");
            //s.Pop(); //закомментил, чтобы дальше код продолжался
            Console.WriteLine();

            //***************Доп задание 1***************
            Console.WriteLine("Доп. задание 1:");
            Console.WriteLine();
            var _s = new Stack("a", "b", "c");
            _s.Merge(new Stack("1", "2", "3"));
            Console.WriteLine();

            //***************Доп задание 2***************
            Console.WriteLine("Доп. задание 2:");
            Console.WriteLine();
            var s1 = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
            s1.messageStorage();
            Console.WriteLine();
        }
    }
}
