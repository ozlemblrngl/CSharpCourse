using System;

internal class Program
{
    private static void Main(string[] args)
    {

        // ********************** STRING ************************

        // Intro();


        // ******************* STRING METHODS *******************

        // .Length() ilgili metnin uzunluğunu verir tüm karakterler ve boşluklar dahil

        string sentence = "My name is Özlem Belörenoğlu";
        var result = sentence.Length;
        Console.WriteLine(result);

        // .Clone() ilgili metnin klonlanmasını sağlar. yeni bir referans oluşturulur

        var result2 = sentence.Clone();
        Console.WriteLine(result2);

        //.EndsWith() ilgili metnin ilgili harfle bitip bitmediğini sorgular. bool döndürür

        bool result3 = sentence.EndsWith("u");
        Console.WriteLine(result3);

        //.StartsWith() ilgili metnin ilgili harfle başlayıp başlamadığını sorgular. bool döndürür

        bool result4 = sentence.StartsWith("My");
        Console.WriteLine(result4);

        //.IndexOf() ilgili metnin indexini gösterir

        var result5 = sentence.IndexOf("name");
        var result6 = sentence.IndexOf(" "); // bulduğu ilk boşluğun indexini verir daha devam etmez diğerlerine bakmaz.
        Console.WriteLine(result5);
        Console.WriteLine(result6);


        //.LastIndexOf() ilgili metni aramaya sondan başlar ve ilgili ifadeyi bulduğunda durur ve baştan itibaren indexini gösterir
        
        // yani aramaya tersten başlayıp bulduğu noktanın metnin en başından itibaren kaçıncı indexinde olduğunu gösterir

        var result7 = sentence.LastIndexOf(" ");
        Console.WriteLine(result7);

        // .Insert() ilgili metne başka bir ifade eklemek için kullanılır.

        var result8 = sentence.Insert(0, "Hello "); // Cümlenin 0. karakterinden itibaren hello ekle demektir
        Console.WriteLine(result8);

        // .SubString() ilgili metni parçalamak için kullanılır.

        var result9 = sentence.Substring(3,4); // 3. karakterden itibaren al yani yazdır yanına 4 eklersek 3. karakterden itibaren 4 karakter al demektir
        Console.WriteLine(result9);

        // .ToLower() ilgili metnin bütün karakterlerini küçük harfe çevirir

        var result10 = sentence.ToLower();
        Console.WriteLine(result10);

        // .ToUpper() ilgili metnin bütün karakterlerini büyük harfe çevirir

        var result11 = sentence.ToUpper();
        Console.WriteLine(result11);

        // .Replace() ilgili metinde belli karakerleri değiştirmek için kullanılır

        var result12 = sentence.Replace(" ","-");
        Console.WriteLine(result12);

        // .Remove() ilgili metinde belli bir indexten sonrasını atmak için kullanılır

        var result13 = sentence.Remove(2,4); // My dan sonrasını atar sadece My'ı yazdırır. Yanına ,4 yazarsak My'dan sonra 4 karakteri kaldırıp gerisini hyazdırır ekrana
        Console.WriteLine(result13);
        Console.ReadLine();
    }

    private static void Intro()
    {
        string city = "Ankara";
        //stringler metinler için kullanılır ve birer char arrays'tir.

        Console.WriteLine(city[0]);

        foreach (var item in city)
        {
            Console.WriteLine(item);
        }

        string city2 = "Istanbul";

        //string result = city + city2; // iki değişken metnini yan yana yazdırır

        //Console.WriteLine(result);

        // yukarıdakinin yerine aşağıdaki gibi yapılabilir

        Console.WriteLine(String.Format("{0}, {1}", city, city2));
    }
}