namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a string: ");
            string word = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (char item in word)
            {
                stack.Push(item);
            }
            bool isPalindrome = true;
            foreach (char item in word)
            {
                if (stack.Pop() != item)
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome)
            {
                Console.WriteLine("string is palindrome");
            }
            else
            {
                Console.WriteLine("string is not palindrome");
            }
        }
    }
}