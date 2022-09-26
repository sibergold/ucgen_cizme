using System;
namespace ucgen_cizme
{
    class Program
    {
        static void Main(string[] args)
        {   sekil ucgen=new sekil();
            Console.WriteLine("Sayı gir.");
            int deger=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Girilen değer için çizilen üçgen: ");
          ucgen.ucgen(deger);
    }
}
}