using System;

abstract class Hayvan
{
    public string isim { get; set; }
    public int yas { get; set; }
    public string tur { get; set; }

    public abstract void SesCikar();
}

class Kopek : Hayvan
{
    public Kopek(string isim, int yas)
    {
        this.isim = isim;
        this.yas = yas;
        tur = "Köpek";
    }

    public override void SesCikar()
    {
        Console.WriteLine("Havlıyor");
    }
}

class Kus : Hayvan
{
    public Kus(string isim, int yas)
    {
        this.isim = isim;
        this.yas = yas;
        tur = "Kuş";
    }

    public override void SesCikar()
    {
        Console.WriteLine("Cikliyor");
    }
}

class Kedi : Hayvan
{
    public Kedi(string isim, int yas)
    {
        this.isim = isim;
        this.yas = yas;
        tur = "Kedi";
    }

    public override void SesCikar()
    {
        Console.WriteLine("Miyavlıyor");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kopek kopek = new Kopek("MrKöpek", 5);
        Kus kus = new Kus("MsKuş", 1);
        Kedi kedi = new Kedi("MrKedi", 6);

        Hayvan[] hayvanlar = { kopek, kus, kedi };

        foreach (Hayvan hayvan in hayvanlar)
        {
            Console.WriteLine($"{hayvan.tur} adı: {hayvan.isim}, yaşı: {hayvan.yas}");
            hayvan.SesCikar();
            Console.WriteLine();
        }
    }
}
