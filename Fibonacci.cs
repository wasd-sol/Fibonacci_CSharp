class Program
{
    public static void Main(string[] args)
    {
        int n = 10; 

        int a = 0;
        int b = 1;

        for (int i = 0; i <= n; i++)
        {
            Console.Write($"{a} ");

            int temp = a + b;
            a = b;
            b = temp;
        }
    }
}