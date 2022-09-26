using System;
namespace ucgen_cizme
{
    class sekil
    {
        public void ucgen(int deger)
        {   
            for (int i = 0; i <=deger;i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
        }
    }
}
}