namespace MasizZaSredenRed
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
           int newelement = numbers.Length / 2;
            Console.WriteLine(numbers[newelement]);
        }
    }
}
