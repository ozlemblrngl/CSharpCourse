internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lütfen kolon sayısını giriniz.");

        int columnNumber = int.Parse(Console.ReadLine());

        while (columnNumber <= 0 || columnNumber > 8)
{
            Console.WriteLine("Lütfen 1 ile 8 arasında bir sayı giriniz.");

            Console.WriteLine("Lütfen kolon sayısını giriniz.");

            columnNumber = int.Parse(Console.ReadLine());

            if (columnNumber > 0 ||  columnNumber < 8)
        break;


        }

        Random rastgele = new Random();
        int[,] number = new int[columnNumber, 6];


        for (int i = 0; i < columnNumber; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                number[i, j] = rastgele.Next(1, 50);

                for (int k = 0; k < j; k++)
                {
                    if (number[i, k] == number[i, j])
                    {
                        number[i, j] = rastgele.Next(1, 50);
                        k = 0;
                    }

                }
                Console.Write(number[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}