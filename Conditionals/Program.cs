internal class Program
{
    private static void Main(string[] args)
    {
        var number = 11;

        // ********************** IF CONDITIONAL *************************

        /*  
          if (number == 10) 
          { 
              Console.WriteLine("Number is 10"); 
          }
          else if(number ==20)
          {
              Console.WriteLine("Number is 20");
          }
          else 
          {
              Console.WriteLine("Number is not 10 or 20");
          }

          // else blogu varsa mutlaka en az bir blok çalışacaktır, çünkü if ve else if ten geriye kalan tüm ihtimaller else blogu içerisinde çalışır.


          // bir diğer yazım şekli aşağıdaki gibi Single Line if denilen yazım şeklidir. aynı zamanda bkz. ternary operatör

          Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

          */


        // ************************** SWITCH CONDITIONAL ************************

        // Switch koşulu if koşulu kadar sık kullanılmaz. Daha çok if kullanımı terih edilmektedir.

        /*
        switch (number)
        {
            case 10:
                Console.WriteLine("Number is 10");
                break;
            case 20:
                Console.WriteLine("Number is 20");
                break;
            default:
                Console.WriteLine("Number is not 10 or 20");
                break;
        }

        */


        // ************************** ÇOKLU ŞARTLARDA ÇALIŞMAK ***********************

        /*

          if (number >= 0 && number <= 100)
          {
              Console.WriteLine("Number is between 0 - 100");
          }
          else if (number > 100 && number <= 200)
          {
              Console.WriteLine("Number is between 101 - 200");
          }
          else if (number >200 || number < 0) 
          {
              Console.WriteLine("number is less than 0 or greater than 200");
          }

          */


        // ************************** NESTED IF STATEMENTS *******************************

        // İç içe if blokları

        if (number < 100)
        {
            if (number > 90 && number < 95)
            {
                Console.WriteLine("number is greater than 90 and less than 95");
            }
        }

        Console.ReadLine();

    }
}