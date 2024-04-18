namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal n1 = 5.5m;
            decimal n2 = 5.4m;

            string n3 = "5";
            string n4 = "5.5";

            int N1 = Convert.ToInt32(n1);
            int N2 = Convert.ToInt32(n2);
            int N3 = Convert.ToInt32(n3);
            int N4 = int.Parse(n4);

            Console.WriteLine(N1);
            Console.WriteLine(N2);
            Console.WriteLine(N3);
             Console.WriteLine(N4);

            Console.WriteLine("I am here !");
        }
    }
}