using System;

public class MyProgram
{
    private static Random random = new Random();
    
    public static void Main(string[] args)
    {
        int[] cekilen = new int[6], tahminler = new int[6];
        int gelen, sayac, sayac2;
        
        for (sayac = 0; sayac <= 5; sayac++)
        {
            tahminler[sayac] = 0;
        }
        for (sayac = 0; sayac <= 5; sayac++)
        {
            Console.WriteLine("Cekilen " + (sayac + 1) + "sayi giriniz: ");
            cekilen[sayac] = (int) readValue();
        }
        for (sayac = 0; sayac <= 5; sayac++)
        {
            gelen = random.Next(49);
            for (sayac = 0; sayac <= 5; sayac++)
            {
                if (tahminler[sayac] == gelen)
                {
                    sayac = sayac - 1;
                }
                else
                {
                    tahminler[sayac] = gelen;
                }
            }
        }
        for (sayac = 0; sayac <= 5; sayac++)
        {
            Console.WriteLine("cekilen " + cekilen[sayac] + " tahmin edilen " + tahminler[sayac]);
        }
    }
    
    // .NET can only read single characters or entire lines from the console.
    // The following function safely reads a double value.
    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
