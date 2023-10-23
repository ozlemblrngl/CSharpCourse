internal class Program
{
    private static void Main(string[] args)
    {

        //***************** TEK BOYUTLU DİZİLER [] **************************


        // string[] students = new string[3];
        // string[] students = new [] { "Engin", "Derin", "Salih" }; ---> şeklinde de yazılabilir
        string[] students = { "Engin", "Derin", "Salih" }; //---> şeklinde de yazılabilir
        //students2[3] = "Ahmet"; // bu şekilde hatalı olur. yukarıda kaç eleman verdiysek o kadarını yazar burayı yazmaz. hata verir.

        //students[0] = "Engin";
        //students[1] = "Derin";
        //students[2] = "Salih";

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine();
        Console.ReadLine();

        // arraylerde nasıl bir değişken tipiyle çalışılıyorsa onlar yazılmalı, değişik tipler yazılmamalı. 

        //********************* ÇOK BOYUTLU DİZİLER [ , ] *************************

        string[,] regions = new string[5,3]
        {
            {"İstanbul", "Balıkesir", "İzmit"},
            {"Ankara", "Konya", "Kırıkkale"},
            {"Antalya", "Adana", "Mersin"},
            {"Rize", "Trabzon ", "Samsun"},
            {"İzmir", "Manisa", "Muğla"}
        };

        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i,j]);
            }
            Console.WriteLine("*****************") ;
        }
           

}
}