namespace Lab_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < 10; i++)
            {
                int result = a + b;
                Console.WriteLine(result);
                a = b;
                b = result; 
            }
        }
    }
}
