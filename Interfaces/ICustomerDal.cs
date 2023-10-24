using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // amacımız uygulamanın bağımlılıklarını indirmek daha moduler kullanımı sağlamak.

    // polimorphism çokbiçimlilik anlamına gelir. Bir nesneyi farklı amaçlarla implemente edip o implementasyonların belli bir kısmına veya tamamına ulaşmaktır.
    // örneklerimizde polimorphism yaptık. ICustomer da hem Oracle hem Sql classları içinde implemente ettik.

    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql Updated");
        }
    }
    class CustomerManager 
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
