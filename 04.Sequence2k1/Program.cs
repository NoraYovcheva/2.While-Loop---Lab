namespace _04.Sequence2k1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // входни данни -> първото ни число е 1 -> всяко следващо е 2пъти предишното + 1
            // четем цяло число n от конзолата
            // отпечатваме от 1 до n 

            int n = int.Parse(Console.ReadLine());

            //for (int number = 1; number <= n; number = number * 2 + 1)    
            // {
            //     Console.WriteLine(number);
            // }

            int number = 1;
            while (number <= n)
            {
                Console.WriteLine(number);
                number = number * 2 + 1;
            }
        }
    }
}
