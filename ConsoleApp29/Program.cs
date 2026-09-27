using System;

class Program
{
    static void Main()
    {
        // Ədədlər siyahısı (massiv)
        int[] ededler = { 10, 20, 30, 40 };

        // 1. Cəm
        int cem = 0;
        foreach (int eded in ededler)
        {
            cem += eded;
        }

        // 2. Hasil
        long hasil = 1;
        foreach (int eded in ededler)
        {
            hasil *= eded;
        }

        // 3. Cəmin faizi (məsələn, 20%-i)
        double faiz = (cem * 20.0) / 100;

        // Nəticələri ekrana çıxarırıq
        Console.WriteLine("Ədədlərin cəmi: " + cem);
        Console.WriteLine("Ədədlərin hasili: " + hasil);
        Console.WriteLine("Cəmin 20%-i: " + faiz);
    }
}