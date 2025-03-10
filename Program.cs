using System;
class MainProgram
{
    public static void Main(String[] args)
    {
        KodePos kodepos = new KodePos();
        Console.WriteLine("Masukkan nama kelurahan: ");
        string input = Console.ReadLine();
        String search = kodepos.getKodePos(input);
        if(search == null)
        {
            Console.WriteLine("Kelurahan tidak ditemukan");
        }
        else
        {
            Console.WriteLine($"Kode Pos {input} adalah {search}");
        }
    }
}

 class KodePos
{
    String[] kelurahan = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
    String[] kodepos = { "40266", "40287", "40267", "40256", "40287", "40286", "40286", "40286", "40272", "40274", "40273" };

    public string getKodePos(string kelurahanTarget)
    {
       for (int i = 0; i < kelurahan.Length; i++)
        {
            if (kelurahan[i].Equals(kelurahanTarget, StringComparison.OrdinalIgnoreCase))
             {
              return kodepos[i];
              }
        }
        return null;
       
    }
}
