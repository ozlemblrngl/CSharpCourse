internal class Program

// DIKKAT NOT : INTERFACE VE ABSTRACT FARKI*********************************************
//
// interface sadece metot imzalarını içerir ve tamamen soyut yapılıdır, abstract class ise hem soyut hem de somut metotları içerebilir ve durum (field (veri alanı) ve property) tutabilir. 

//*************** SOLID ***************************************************************

// interfacein doğru planlanması gerekliliğine ilişkin preinsi SOLID; INTERFACE SEGREGATION SOLID'IN I HARFİNE DENK GELİR. SOLID BİR KISALTMADIR.
// aşağıda yapılanlar Interface Segregation Principle a örnektir.

/*
 I - Interface Segregation Principle (Arayüz Ayrımı Prensibi): İstemci sınıflar, ihtiyaç duymadıkları arayüz metotlarına bağlı olmamalıdır.
 * Yani, bir arayüz, onu kullanacak sınıfların ihtiyaçlarına uygun olarak bölünmelidir.
 * Bu prensip, gereksiz bağımlılıkları azaltır ve sınıflar arasındaki ilişkileri daha belirgin hale getirir.
 */

/*************SOLID prensiplerini oluşturan kelimelerin açılımları:

S - Single Responsibility Principle (Tek Sorumluluk Prensibi): Bir sınıfın (veya modülün) sadece bir tek sorumluluğu olmalıdır. 
Yani, bir sınıf yalnızca bir işi yapmalıdır. Bu, sınıfları küçük tutarak ve her bir sınıfı yalnızca bir amaç için değiştirmeye zorlayarak kodun sürdürülebilirliğini artırır.

O - Open/Closed Principle (Açık/Kapalı Prensibi): Bir sınıf, genişletilmeye açık (open) ancak değişikliğe kapalı (closed) olmalıdır. 
Yani, mevcut kodu değiştirmeden yeni özellikler eklemek mümkün olmalıdır. Bu prensip, kodun değişikliklere karşı hassasiyetini azaltarak kodun uzun vadeli sürdürülebilirliğini sağlar.

L - Liskov Substitution Principle (Liskov Yerine Koyma Prensibi): Bir alt sınıf (veya türetilmiş sınıf), üst sınıfın yerine geçebilmelidir. 
Yani, bir programda bir sınıf yerine başka bir sınıf kullanıldığında programın doğru çalışması sağlanmalıdır. Bu prensip, türetilmiş sınıfların temel sınıfların yerine geçebilirliğini koruyarak kodun tutarlılığını ve doğruluğunu sağlar.

I - Interface Segregation Principle (Arayüz Ayrımı Prensibi): İstemci sınıflar, ihtiyaç duymadıkları arayüz metotlarına bağlı olmamalıdır. 
Yani, bir arayüz, onu kullanacak sınıfların ihtiyaçlarına uygun olarak bölünmelidir. Bu prensip, gereksiz bağımlılıkları azaltır ve sınıflar arasındaki ilişkileri daha belirgin hale getirir.

D - Dependency Inversion Principle (Bağımlılıkların Ters Çevirme Prensibi): Üst seviye modüller, alt seviye modüllere bağımlı olmamalıdır. 
Her ikisi de soyutlamalara (abstractions) dayanmalıdır. Bu prensip, yüksek seviyeli modüllerin düşük seviyeli ayrıntılara olan bağımlılığını azaltır ve daha esnek, değiştirilebilir kod yapısı oluşturur.

Bu SOLID prensipleri, nesne yönelimli tasarımın temel taşları olarak kabul edilir ve yazılım geliştirme süreçlerinde daha kaliteli ve sürdürülebilir kod yazmanıza yardımcı olur.
 
 */


{
    private static void Main(string[] args)
    {
        IWorker[] workers = new IWorker[3]
        {
            new Manager(),
            new Worker(),
            new Robot()
        };

        foreach (var worker in workers) 
        {
            worker.Work();
        }


        IEat[] eaters= new IEat[2]
        {
            new Manager(),
            new Worker()
        };

        foreach (var eater in eaters) 
        {
            eater.Eat();
        }

    }
}

interface IWorker
{
    void Work();

}

interface IEat
{
    void Eat();
}

interface ISalary
{
    void GetSalary();
}

// BİR CLASS BİRDEN FAZLA INTERFACE I IMPLEMENTE EDEBİLİR. 
class Manager : IWorker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

class Worker : IWorker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

class Robot : IWorker
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}

