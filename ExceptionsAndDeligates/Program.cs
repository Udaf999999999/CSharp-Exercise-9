namespace ExceptionsAndDeligates;
internal class Program
{
    static int Division(int a, int b)
    {
        return a / b;
    }
    public static void Minus(int a, int b) => Console.WriteLine(a - b); 
    public static void Sum(int a , int b) => Console.WriteLine(b + a);
    public delegate void MinusDeilgate(int a, int b);
    public static int AddNumbers(int param1, int param2) => param1 + param2;
    public static void Display(string message) => Console.WriteLine(message);
    public static bool IsApple(string modelName) => modelName == "IPhone X"? true: false;
    static void Main(string[] args)
    {
        MinusDeilgate minusDeilgate = Minus;
        minusDeilgate += Sum;
        minusDeilgate -= Minus;
        minusDeilgate(6, 5);

        Func<int, int, int> Addition = AddNumbers;
        Action<string> action = new Action<string>(Display);
        Predicate<string> predicate = IsApple;

        //try
        //{
        //    throw new RankException();
        //}
        //catch (Exception ex) when (ex is ArgumentOutOfRangeException)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //catch (RankException ex)
        //{ 
        //    Console.WriteLine(ex.GetType()); 
        //}
    }
}
