using System.Reflection.Metadata.Ecma335;

namespace ExceptionsAndDeligates;
internal class Program
{
    static int Division(int a, int b)
    {
        return a / b;
    }
    public static void Minus(int a, int b) => Console.WriteLine(a - b);
    public static void Sum(int a, int b) => Console.WriteLine(b + a);
    public delegate void MinusDeilgate(int a, int b);
    public static int AddNumbers(int param1, int param2) => param1 + param2;
    public static void Display(string message) => Console.WriteLine(message);
    public static bool IsApple(string modelName) => modelName == "IPhone X" ? true : false;
    delegate void ShowMessageDelegate(string _message);
    delegate int RandomNumberDelegate();
    public class Animal { }
    public class Dog : Animal
    {
        public int countPaw;
        public void Show()
        {
            Console.WriteLine(countPaw);
        }

    }
    public static void ShowAnimalChoutPaw(Dog dog)
    {
        dog.Show();
    }
    public delegate void DelegeteAnimal(Dog dog);
    public class Car { }
    public class Lexus : Car { }
    public delegate Car CarDelegate();
    public static Car CarHandler() => null;
    public static Lexus LexusHandler() => null;
    public class Parent { }
    public class Child : Parent { }
    public delegate void ChildInfo(Child child);
    public static void GetParentInfo(Parent parent) {}
    static void Main(string[] args)
    {
        ChildInfo childDelegate = GetParentInfo;
        childDelegate(new Child());


        //CarDelegate carDelegate = LexusHandler;

        //DelegeteAnimal delegeteAnimal = ShowAnimalChoutPaw;
        //ShowMessageDelegate showMessageDelegate = (string str) => Console.WriteLine(str);
        //showMessageDelegate.Invoke("Hello World!");

        //RandomNumberDelegate randomNumberDelegate = () => new Random().Next(0, 100);
        //int result = randomNumberDelegate.Invoke();
        //Console.WriteLine(result);

        //MinusDeilgate minusDeilgate = Minus;
        //minusDeilgate += Sum;
        //minusDeilgate -= Minus;
        //minusDeilgate(6, 5);

        //Func<int, int, int> Addition = AddNumbers;
        //Action<string> action = new Action<string>(Display);
        //Predicate<string> predicate = IsApple;

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
