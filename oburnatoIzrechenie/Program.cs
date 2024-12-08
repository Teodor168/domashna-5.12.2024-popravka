namespace oburnatoIzrechenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a sentence: ");
            string[] sentence = Console.ReadLine().Split(" ").ToArray();
            Stack<string> stack = new Stack<string>();
            foreach (string word in sentence)
            {
                stack.Push(word);
            }

            Console.WriteLine($"reversed sentence: {string.Join(" ", stack)}");
            Console.WriteLine($"count of words is: {stack.Count}");
            
        }
    }
}
