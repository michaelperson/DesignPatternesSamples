using static designPatterns.Correct;

namespace designPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hub hub = new();
            Hub noHub = new();

            Sub one = new("one");
            Sub two = new("two");
            Sub three = new("three");

            Sub noFour = new("noFour");

            one.Join(hub);
            two.Join(hub);
            three.Join(hub);

            noFour.Join(noHub);

            Console.WriteLine("---TEST 1---");
            one.Update(5);
            Console.WriteLine("---TEST 2---");
            two.Update("Hello World !");
            Console.WriteLine("---TEST 3---");
            three.Update(true);
            Console.WriteLine("---TEST 4---");
            noFour.Update(false);
        }
    }
}
