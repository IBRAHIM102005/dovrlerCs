namespace dovrler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-dən n-ə qədər əddlərin faktorialını hesablayan proqram
            int n=int.Parse(Console.ReadLine());
            int s = 0;
            if (n == 0 )
                {
                    s = 1;
                
                }
            else if (n < 0)
            {
                Console.WriteLine("menfi ededin faktoriali olmur !!!");
                
            }
            while (n > 0)
            {
                int h = 1;
                for (int i = 1; i < n+1; i++)
                {
                    h = h * i;
                   
                }
                s = s + h;
                n= n - 1;
            }
            
            Console.WriteLine(s);
        }
    }
}