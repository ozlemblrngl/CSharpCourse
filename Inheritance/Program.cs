internal class Program
{
    //************************** ÇOK ÖNEMLİ DİKKAT!**********************************************************************

    // interface ler de birer inheritance örneği gibi çalışırlar ama inheritance değildirler birer implementasyondur.Ancak inheritance gibi kullanılırlar.
    // bir classa parent class sadece 1 tane atanabilir. birinin sadece bir parentı olabilir. Örn class Person2 yazıp, class Student'e ya da class Customer'a Person'ı atadıktan sonra
    // Person2 yi atayamayız. kalıtım sadece Person'la kurulmuştur orada başka parent kabul etmez.
    // bu özellik de interface ile arasındaki farktır. çünkü bir sınıf birden fazla interface alabilirken birden fazla inheritance alamaz.
    // eğer class hem inheritance hem interface alıyorsa önce inheritance yazılır sonra interface(ler) yazılır.
    // inheritance kullanabileceğimiz durumlarda interface kullanabiliriz çünkü her ne kadar implementasyon olsa da interface ler inharitance gibi kullanılabilirker.
    // peki sadece inharitance kullanmamız gereken durumlar yok mudur? evet vardır: Abstract sınıflar bizim için inheritance bağlamında çok önemli bir yer teşkil etmektedir.
    // Abstracları öğrendiğimizde ne zaman inheritahnce ne zaman interface kullanılacağı görülecektir. Ancak temel olarak eğer interface kullanabiliyor ve
    // inheritance ihtiyaç olduğunu bir zorunluluk olduğunu düşünmüyorsak interface kullanabiliriz.

    private static void Main(string[] args)
    {

        Customer customer = new Customer();
        customer.FirstName = "Test";

        Console.WriteLine(customer.FirstName);

        Person[] persons = new Person[3]
        {
            new Customer() {FirstName = "Özlem"},
            new Student() {FirstName = "Mustafa"},
            new Person() {FirstName = "Zeyzey"}
        };

        // yukarıda yazarken Person() a da yönlendiriyor. Interface de bunu yapmıyordu. Çünkü interfaceler tek başına bir anlam ifade etmiyor ama inheritancelar tek başına da
        // bir anlam ifade ediyorlar.

        foreach (var person in persons)
        {

            Console.WriteLine(person.FirstName);
        }

        Console.ReadLine();
    }
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }
}

class Customer : Person
{
    // Customer'ın parent ı Person'dır. Customer, Person'ın child ıdır. Bu nedenle Customer, Person'dan kalıtım sağlar ve özelliklerini alır. 
    // ancak Customer child olarak kendine has özellikler de barındırabilir.

}

class Student : Person
{
    // Student'ın parent ı Person'dır. Student, Person'ın child ıdır. Bu nedenle Student, Person'dan kalıtım sağlar ve özelliklerini alır. 
    // ancak Student child olarak kendine has özellikler de barındırabilir.
}