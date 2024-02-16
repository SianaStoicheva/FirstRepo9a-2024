namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Day broi na elementite: ");
            int n = int.Parse(Console.ReadLine());
            //array
            int[] numbers = new int[n];
            //1.input the elements
            for (int i = 0; i < numbers.Length-1; i++) 
            {
                Console.Write($"num[{i}] = ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //2.
            long sum = 0l;
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine($"Sum = {sum}");

            //4.
            int min = int.MaxValue;
            int minpOS = int.MaxValue;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < min )
                {
                    min = numbers[i];
                    minpOS = i;
                }
            }
            Console.WriteLine($"{min} ===> {minpOS} index");

            //5.Print ALL element
            for (int i = 0;i < numbers.Length-1; i++)
            {
                Console.WriteLine($"num[{i}] = {numbers[i]}");
            }
        }
    }
}
