using Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {

        // InterfacesIntro();

       // Demo();

        ICustomerDal[] customerDals = new ICustomerDal[3]
        {
            new SqlServerCustomerDal(), 
            new OracleCustomerDal(),
            new MySqlCustomerDal(),
         };

        foreach (var customerDal in customerDals) 
        {
         customerDal.Add();
        }


        Console.ReadLine();
    }

    static void Demo()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new OracleCustomerDal());
        customerManager.Add(new SqlServerCustomerDal());
    }
    static void InterfacesIntro()
    {
        PersonManager manager = new PersonManager();

        Customer customer = new Customer
        {
            Id = 1,
            FirstName = "Özlem",
            LastName = "Belörenoğlu",
            Address = "Ankara"
        };
        manager.Add(customer);

        // yukarıdaki ifade aşağıdaki gibi de yazılabilir. nasıl kolay geliyorsa.

        //manager.Add(new Customer { Id = 1, FirstName = "Özlem", LastName = "Belörenoğlu", Address = "Ankara" });

        Student student = new Student
        {
            Id = 1,
            FirstName = "Mustafa",
            LastName = "Emir",
            Department = "İletişim"

        };

        manager.Add(student);
    }
}

//Interfacelerin en büyük kullanım amacı bir temel nesne oluşturup bütün nesneleri ondan implemente etmektir. Class lar somutken interface ler soyuttur.
// bir arayüz (interface), bir nesnenin hangi yöntemleri (metodları) ve özellikleri (değişkenleri) içermesi gerektiğini belirten bir şablondur.
// Bir sınıf bir arayüzü uygular (implement) ettiğinde, o sınıfın içinde belirtilen metodları ve özellikleri içermesi zorunlu hale gelir.
// (Abstract Methods) Arayüz içinde tanımlanan metodlar somut bir implementasyona sahip değildir, yani içerikleri belirtilmez.
// Bu metodları uygulayan sınıflar, bu metodları kendi ihtiyaçlarına uygun olarak doldurmalıdır.
// Arayüzler, çoklu kalıtımı desteklediği için bir sınıf birden fazla arayüzü uygulayabilir.
// Bu, farklı türde işlevselliği olan birden fazla kaynağı bir arada kullanmanıza olanak tanır. 
// (Constants)Arayüzler aynı zamanda sabit değerler içerebilir, yani değişkenlerin değerleri değiştirilemez. Bu değerler genellikle büyük harflerle yazılır.
// interface ler aşağıda gösterilen amacının çok daha ötesinde büyük bir amaç için kullanılırlar.
// interfaceler bir inheritance değildir ama java ve csharp gibi dillerde onun gibi kullanılabilirler

// bir interface hiçbir zaman tek başına newlenemez çünkü tek başına bir anlamı yoktur. yani tek başına bir nesne üretilemez. yani IPerson person = new IPerson yapamayız.
// ancak aşağıda yer alan örneklerde de görüleceği üzere IPerson person = new Student() ya da IPerson person = new Customer() şeklinde ilgili sınıflardan nesne üretimi yapılabilir.

// amacımız uygulamanın bağımlılıklarını indirmek daha moduler kullanımı sağlamak.


// polimorphism çokbiçimlilik anlamına gelir. Bir nesneyi farklı amaçlarla implemente edip o implementasyonların belli bir kısmına veya tamamına ulaşmaktır.
// örneklerimizde polimorphism yaptık. ICustomer da hem Oracle hem Sql classları içinde implemente ettik.

interface IPerson
{
    // burada IPerson için özellikler tanımlıyoruz.

    int Id { get; set; }    // interfaceler yazılırken tamamen metodun imzası, void se void, dönüş değeri varsa dönüş değeri(veri tipi), değişken ismi ve değeri yazılır.
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    //    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    // Yukarıdaki IPerson interfaceinin implementation ı görüntü olarak güzel değil o nedenle aşağıdaki gibi daha temiz bir görüntüde yazabiliriz.
    // aşağıdaki ilk üç özellik interfaceden implemente edildi ama sonuncu Address özelliği sadece customer'a ait bir özellik (property)

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }

}

class Student : IPerson
{
    //    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    // Yukarıdaki IPerson interfaceinin implementation ı görüntü olarak güzel değil o nedenle aşağıdaki gibi daha temiz bir görüntüde yazabiliriz.
    // aşağıdaki ilk üç özellik interfaceden implemente edildi ama sonuncu Department özelliği sadece student'e ait bir özellik (property)

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Department { get; set; }
}

// parametre verdiğimizde metota interfaceden gitmemiz o interface in implement edildiği tüm sınıflarda o metotdu kullanabilmemize olanak sağlar. Bu nedenle interface önemlidir.
// örn parametrede Add(Customer customer) yazsaydık student için add metodunu kullanmak istediğimizde bize hata verecekti customerda student tanımlı olmadığından.
// ancak IPerson interfaceini kullandığımızda ise hem student hem customer IPerson interfaceinden implemente edilen sınıftan ttüretilen nesneler olduğu için
// her iki türetilen nesneye de metot uygulanabilir hale gelecektir.
class PersonManager
{
    public void Add(IPerson person) // buraya parametre olarak bir müşteri nesnesi ver anlamındadır. bir nesne de parametre olabilir. veri tipi yerine geçebilir.bkz örn. Customer
    {
        Console.WriteLine(person.FirstName);
    }
}