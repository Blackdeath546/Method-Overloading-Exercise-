namespace MethodOverloading
{
    public class Program
    {

        static void Add(int a, int b)
        {
            int sum = a + b; 
            Console.WriteLine(a + b);
        }
        
        static void Add(double a, double b)
        {
            double sum = a + b; 
            Console.WriteLine(a + b);
        }
        
        static void Add(double a, double b, string c, bool d)
        {
            var sum = a + b;
            if (sum == 1 || sum == -1)
            {
                c = "dollar";
            }
            else if (sum > 1 || sum == 0 || sum < -1)
            {
                c = "dollars";
            }
            else if (sum < 1 && sum > 0 || sum < -1 && sum > 0)
            {
                c = "cents";
            }
           
            if (d == true)
            { 
                Console.WriteLine($"{a + b} {c}");
                
            }
            else
            {
                Console.WriteLine($"{a + b}");
            }
        }
        static void Main(string[] args)
        {
            Add(2, 3);
            Add(2.5, 2.6);
            Add(5, 6, "dollars", false);
        }
    }
}
