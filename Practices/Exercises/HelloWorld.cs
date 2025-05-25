namespace Practices.Exercises;

public class HelloWorld
{

    public static class HelloWorldV1
    {
        public static string HelloV1()
        {
            return "Hello, World! 1";
        }

        public static string HelloV2() => "Hello, World! 2";

    }

    public static void HelloWorldV2()
    {
        static string HelloV3()
        {
            return "Hello, World! 1";
        }

        static void HelloV4() => System.Console.WriteLine("Hello, World! 2");

    }

}
