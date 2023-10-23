internal class Program
{

    private static void Main(string[] args)
    {

        // metotlar DON'T REPEAT YOURSELF mantığıyla yapılır. 

        /*
        Add();
        Add();
        Add();
       
        var result = Add2(20,30);
        Console.WriteLine(result);
        */


        // var result = Add2(20); ---> burada default parametre atadığımız için number2'ye değer girilmezse default değer 30 olarak kabul edilerek toplama işlemi yapılacaktır.
        // var result = Add2(); ---> burada hem number1 hem number2 için ayrı ayrı default değer atandığından değer girilmese de default değerler toplanır.

        // int number1 = 20; // ---> ref için bu şekilde değer atanarak yazılmalı
        // int number1; -----> out da bu şekilde kullanabiliriz boş değerle; ancak refte boş değerle kullanamayız.
        // int number2 = 100;
        // var result2 = Add3(ref number1,number2);
        // Console.WriteLine(result2);
        // Console.WriteLine(number1);

        // DİKKAT : number1 değeri her ne kadar metot içinde 30 olsa da bu scopetaki değeri 20'dir.
        // ancak ref değeri atarsak başına ref yazmak suretiyle o zaman bu scopetaki değeri de number1'in her ne kadar 20 yazsa da metottaki ref değeri olan 30 olur.

        // Ref'in bir diğer alternatifi "out" keyword'udur. ref yazan yerlere out yazabiliriz.
        // ref ve out 'un bir farkı vardır o da; ref için int number = 20; değer ataması şeklinde number1 e değer atanması gerekirken;
        // out için int number1; yazmamız yani değer atamadan boş değerli yazmamız mümkündür.

        Console.WriteLine(Multiply(2, 4));
        Console.WriteLine(Multiply(2, 4, 5));

        Console.WriteLine(Add4(1, 2, 3, 4, 5, 6)); // params metodu ile buraya dilediğimiz kadar sayı yazabiliriz. ancak tiplerin aynı olması lazım

        Console.ReadLine();
    }

    static void Add()
    {
        Console.WriteLine("Added!!!");
    }

    static int Add2(int number1, int number2)
    {
        var result = number1 + number2;
        return result;
    }

    // ********** DEFAULT PARAMETRELİ METOTLAR ******

    // eğer sayılardan birine değer verilmezse default değer atamamızı sağlar. örn aşağıda number2 parametresine değer atanmaması durumunda default değeri 30 olarak atanmıştır.
    // ÖNEMLİ NOT : birden fazla default değer verilebilir ancak default değerleri her zaman metodun en sonunda yer almalıdır. 
    /*
     
    static int Add2(int number1 = 20, int number20 = 30)
    {
        var result = number1 + number2;
        return result;
    }
    */

    static int Add3(ref int number1, int number2)
    {
        number1 = 30;
        return number1 + number2;

    }

    // ****************** METHOD OVERLOADING **********************

    // multiply metodu parametrelerin artırılması suretiyle birden fazla metot olabilir. metotların imzalarında bu şekilde sıkıntı olmaz. Bu şekilde kullanım mümkündür.
    // bu duruma method overloading denir.

    static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2 * number3;
    }

    // ****************** PARAMS KEYWORD ************************
    // Sürekli number3, number4 , number5 vs yazarak method overload yapamayız çünkü kod yazma pratiğine aykırıdır.
    // bunun yerine eklenmek istenen sayı adetini istediğimiz kadar girmemizi sağlayan keyword params'dır.
    // burada toplam metoduna girmesini istediğimiz kadar sayı yazabiliriz.Ancak tiplerin aynı olması lazım.
    // illa sayıların hepsi paramsla belirlenecek diye bir şey yok önce bir sayı parametresi atayıp sonra params 'ı ekleyebiliriz metot parametrelerine
    // örn
    // static int Add4(int number, params int[] numbers)
    // yine params metot parametrelerinin en sonunda olmak zorunda. aksi halde çalışmayacaktır.
    static int Add4(params int[] numbers)
    { 
        return numbers.Sum();
    }
}