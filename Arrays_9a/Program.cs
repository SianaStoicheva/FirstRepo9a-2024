namespace Arrays_InputOtput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklariram masiv ot 13 elementa
            double[] grades = new double[13];//{1,2,3,4}
            string[] names = new string[13]{"Lubo", "Milen","Misho","Rado","Svetlio","Siana","Silviq","Stanislav","Tedo","Hristian","Hristomir","Cvetelina","Cvetina"};
            //Vuvejda se elementite ot klaviatyrta
            for (int index = 0; index < grades.Length; index++)
            {
                Console.Write($"{index+14}. {names[index]} e >>>");
                grades[index] = double.Parse(Console.ReadLine());
            }
            //Obrabotka
            grades[9] = 6;
            names[8] = "Teodor";
            grades[1] = 5.234;
            grades[1] = Math.Ceiling(5.234);
            Console.WriteLine($"Na {names[1]} is grade is {grades[1]}");
            grades[6] = 6;
            //Otpechatvane na rezultat
            for (int j = 0;j < names.Length;j++) 
            {
                Console.WriteLine($"{j + 14}.{names[j]}");
            }
        }
    }
}
