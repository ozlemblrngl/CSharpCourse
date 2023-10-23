internal class Program
{
    private static void Main(string[] args)
    {
        // Value Types

        // Console.WriteLine("Hello World!");

        // ****************** 1- Integer data type************************

        int number1 = 10;
        int number2 = 20;
        int number3 = 2147483647;
       
        Console.WriteLine("number1 is {0}, number2 is {1}", number1, number2); // her bir süslü parantez içerisindeki değer ilgili değişkenin indexini gösterir.
        Console.WriteLine("number3 is {0}", number3);


        // ****************** 2- Long data type ***************************

        long number4 = 2147483648;
        Console.WriteLine("number4 is {0}", number4);
        // int'e göre değeri iki katı yer kaplar long değişken tipinde. Long değişken tipi int'e göre daha geniş bir sayı aralığını ifade eder.
        // int 32 bitlik yer kaplarken, long 64 bitlik yer kaplar. 

        long number5 = 9223372036854775807;
        Console.WriteLine("number5 is {0}", number5);


        // ***************** 3- Short data type ***************************

        short number6 = 32767; 
        Console.WriteLine("number6 is {0}", number6);
        // -32768 olur, eksi değerde bir eksi değer fazladır. Short veri tipi bu aralıkta yer alır.
        // short 16 bitlik yer tutar.


        // **************** 4- Byte data type *****************************

        byte number7 = 255;
        Console.WriteLine("number7 is {0}", number7);
        //8 bit yani 1 byte yer kaplar. 0 ile 255 de dahil olmk üzere bu değerler arasında değer tutar.


        // **************** 5- Bool data type *****************************

        bool condition = false; // ya da true olabilir
        Console.WriteLine(condition);
        // bool mantıksal bir veri tipidir. tuttuğu değer true ya da false tur. Genellikle if gibi karşılaştırma bloklarında kullanılır.
        // condition (şart) bloklarında sıklıkla kullanılır.


        // *************** 6- Char data type *******************************

        char character = 'A';
        Console.WriteLine(character);
        // ASCI denilen genellikle klavyede kullanılan tüm değerler kullanılabilir


        // *************** 7- String data type *******************************

        string city = "Ankara";
        Console.WriteLine(city);
        // string için karakterleden (char) oluşan bir dizi tipi diyebiliriz. Metinsel veri tipi tutar.


        // *************** 8- Double data type *******************************

        double number8 = 10.4;
        Console.WriteLine("number8 is {0}", number8);
        // bu veri tipinde tamsayı veri tipleri int, byte, long veri tiplerinden farklı olarak, tam sayıya ek ondalıklı sayı tiplerini de tutabiliyoruz. 


        // *************** 9- Decimal data type *******************************

        decimal number9 = 10.4m;
        Console.WriteLine("number9 is {0}", number9);

        // int için long ne ise double için de decimal veri tipi odur. decimal daha geniş bir ondalık aralığı ifade eder double a göre. 
        // değer atanırken değerin yanına bir "m" ifadesi eklenmesi gerekir. m harfi büyük veya küçük olabilir önemli değil. 

        decimal number10 = 10;
        Console.WriteLine("number10 is {0}", number10);
        // decimal için eğer sayı ondalıklı değil tam sayı ise değeri atarken değerin yanına m yazmamıza gerek yok.


        // *************** 10- Enum data type *******************************

        // if (Days.Monday == blablabla)

        Console.WriteLine(Days.Friday);
        Console.WriteLine((int)Days.Friday); // 4 / integer değere dönüştürdüğümüzde indexteki 4. değer friday olduğu için sonuc 4 çıkmaktadır. 

        // enum Days te yazılan haftanın günlerini defalarca yazmamızı engeller. kısaca programda birden azla kullanılacak bir verinin defalarca yazılmasını engeller.
        // magic string'in kodun sürekli okunulabilirliği ve düzenlenebilirliğini olumsuz etkilemesi nedeniyle enum işimize yaramaktadır.Kodun maliyeti azalır, hataların önlenmesinde önemlidir.
        // değişiklik bir yerde yapılarak birçok yerde geçen aynı ifadenin değişimi sağlanır, tek tek her birini değiştirmekle uğraşılmaz.
        // enumlarda tip dönüşümleri önemlidir.



        // *************** 11- Var Keyword *******************************

        var number11 = 10;
        number11 = 'A';
        Console.Write(number11);

        // var bir değişken değildir. değişken tutmak için kullanılan bir keyworddur.
        //örnekte ilk olarak integer olarak tanımladığımız için ikinci atamadaki A karakterinin ASCII değerini döndürür yani integer değer olarak döndürür.
        // başta ne veri tipinde verdiysek o şekilde devam edecektir var'da.

        Console.ReadLine();
    }

}
enum Days
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    //Monday =10, Tuesday=20, Wednesday, Thursday, Friday, Saturday, Sunday ---> şeklinde değişkenin başlangıç değerini de belirleyebilir, her birine farklı değer de atayabiliriz.
}