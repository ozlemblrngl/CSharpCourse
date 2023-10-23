using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer // bir müşterinin özelliklerini tutmak için kullanırız
        //setle değer ataması yapılır, get le atanan değer okunur
    {

        //field bir classın içinde properties yani özellikleri tutmak için kullanılan alandır.
        //public string FirstName; // bu şekilde de yazılabilir :  public string FirstName { get; set; }

        // properties eğer classın içeriisnde özellikleri anlatacaksak property tanımlarız field değil.
        public int Id { get; set; }


        // aşağıdaki gibi bir field üzerinde değeri verirken(set) veya değeri okurken(get) başka bir şey yapmak istersek aşağıdaki gibi yazmalıyız. 
        // bu duruma da ENCAPSULATION denir. 

        private string _firstName;
        public string FirstName 
        {
            get { return "Mrs." + _firstName; }
          
            set { _firstName = value; } // value set etmek istediğimiz değere karşılık gelir
            
        }

        public string LastName { get; set; }

        public string City { get; set; }
    }
}
