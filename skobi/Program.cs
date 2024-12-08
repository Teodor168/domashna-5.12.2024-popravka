namespace skobi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give brackets: ");
            string brackets = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isBalanced = true;

            foreach (char item in brackets)
            {
                if (item == '(')
                {
                    stack.Push(item);
                }
                else if (item == ')')
                {
                    if (stack.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }
                    stack.Pop();
                }
            }

            if (isBalanced && stack.Count == 0)
            {
                Console.WriteLine("Balanced");
            }
            else
            {
                Console.WriteLine("Not Balanced");
            }
        }
    }
}