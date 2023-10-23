using Classes;
using System.ComponentModel;
using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager(); // burada ilgili sınıfın bir örneğini (instance) yani bir referansını oluşturuyoruz.

        // classlar Pascal Case ile instancelar Camel Case ile yazılır.

        customerManager.Add();
        customerManager.Update();


        ProductManager productManager = new ProductManager(); // burada ilgili sınıfın bir örneğini (instance) yani bir referansını oluşturuyoruz.
        productManager.Add();
        productManager.Update();

        Customer customer = new Customer();
        customer.City = "Ankara";
        customer.Id = 1;
        customer.FirstName = "Özlem";
        customer.LastName = "Belörenoğlu";

        // yukarıdaki ifade aşağıdaki gibi de yazılabilir. Aralarında hiçbir fark yok

        Customer customer2 = new Customer
        {
            Id = 2, City = "İstanbul", FirstName = "Derin", LastName = "Demiroğ"
        };


        Console.WriteLine(customer2.FirstName);


        Console.ReadLine();
    }
}


// burada yeni clas içerisinde birden fazla metot oluşturduk. 
// bir class ı kullanmak için onun örneğini oluşturmamız gerekir. (instance)
class CustomerManager
{

    public void Add()
    {
        Console.WriteLine("Customer Added!");
    }

    public void Update()
    {
        Console.WriteLine("Customer Updated!");
    }
}

class ProductManager

{
    public void Add()
    {
        Console.WriteLine("Product Added!");
    }

    public void Update()
    {
        Console.WriteLine("Product Updated!");
    }

}