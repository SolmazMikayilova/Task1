namespace Do_While_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("enter number between 10 and 20");
            int n;
            string a;
            n = int.Parse(Console.ReadLine());
            if ( n<=10 || n >= 20)
            {
               
                Console.WriteLine("this is false");
                Console.WriteLine("continue or not");
                a = Console.ReadLine();
                if (a == "continue")
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("Enter number");
                    if (a == "no")
                    {
                        Console.WriteLine("stop");
                    }
                   
                }
            }
            else
            {
                Console.WriteLine("this is true");
            }
            int num2;
           num2 = int.Parse(Console.ReadLine());
        
            if (num2 % 2 == 0)
            {
                Console.WriteLine("this is even number");
            }
            else
            {
                Console.WriteLine("this is odd number");
            }
        }
    }
}
