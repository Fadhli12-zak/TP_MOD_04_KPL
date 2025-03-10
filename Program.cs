using System;
class MainProgram
{
    public static void Main(String[] args)
    {
        Console.WriteLine("pilih soal:(1/2) ");
        int pilih = Console.Read();
        if (pilih == 1)
        {
            KodePos kodepos = new KodePos();
            Console.WriteLine("Masukkan nama kelurahan: ");
            string input = Console.ReadLine();
            String search = kodepos.getKodePos(input);
            if (search == null)
            {
                Console.WriteLine("Kelurahan tidak ditemukan");
            }
            else
            {
                Console.WriteLine($"Kode Pos {input} adalah {search}");
            }
        }
        else { 
            DoorMachine door = new DoorMachine();
            door.doorMachine();
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

class DoorMachine
{
    enum State { TERKUNCI, TERBUKA};
    public  void doorMachine()
    {
        State state = State.TERKUNCI;
        string[] screenName = { "PINTU TERKUNCI","PINTU TERBUKA" };
        string command = null;
        int i = 0;
        while (command != "EXIT")
        {
            if (i > 0) {
                Console.Write("Enter Command : ");
            }
            command = Console.ReadLine();
            switch (state)
            {
                case State.TERKUNCI:
                    if (command == "KUNCI PINTU")
                    {
                        state = State.TERKUNCI;
                        Console.WriteLine(screenName[(int)state]);
                    }
                    else if (command == "BUKA PINTU") { 
                        state = State.TERBUKA;
                        Console.WriteLine(screenName[(int)state]);
                    }
                    break;
                case State.TERBUKA:
                    if (command == "BUKA PINTU")
                    {
                        state = State.TERBUKA;
                        Console.WriteLine(screenName[(int)state]);
                    }
                    else if (command == "KUNCI PINTU")
                    {
                        state = State.TERKUNCI;
                        Console.WriteLine(screenName[(int)state]);
                    }
                        break;
            }
            i++;
        }
       
    }
}
 
