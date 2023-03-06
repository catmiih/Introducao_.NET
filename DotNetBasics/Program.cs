internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Selecione um valor:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Selecione o segundo valor:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"O resultado da soma é {Soma(number1, number2)}");
    }

    public static int Soma(int num1, int num2)
    {
        return num1 + num2;
    }
}