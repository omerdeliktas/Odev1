using System;

class Ogrenci
{
    public string Ad { get; set; }
    public int Yas { get; set; }

    public Ogrenci(string ad, int yas)
    {
        Ad = ad;
        Yas = yas;
    }

    public void DurumGoster()
    {
        Console.WriteLine($"Ad: {Ad}, Yaş: {Yas}");
    }
}

class TembelOgrenci : Ogrenci
{
    public int TembellikDurumu { get; set; }

    public TembelOgrenci(string ad, int yas, int tembellikSeviyesi)
        :base (ad, yas)
    {
        TembellikDurumu = tembellikSeviyesi;
    }

public override void DurumGoster()
{
    Console.WriteLine($"Ad: {Ad}, Yaş: {Yas}, Tembellik Durumu: {TembellikDurumu}");
}
}

class CalıskanOgrenci : Ogrenci
{
    public int CalıskanlıkDurumu { get; set; }

    public CalıskanOgrenci(string ad, int yas, int calıskanlıkDurumu)
        : base(ad, yas)
    {
        CalıskanlıkDurumu = calıskanlıkDurumu;
    }

    public override void DurumGoster()
    {
        Console.WriteLine($"Ad: {Ad}, Yas: {Yas}, Çalışkanlık Durumu: {CalıskanlıkDurumu}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci1 = new Ogrenci("Omer", 11);
        ogrenci1.DurumGoster();

        TembelOgrenci tembelOgrenci = new TembelOgrenci("Mehmet", 12, 5);
        tembelOgrenci.DurumGoster();

        CalıskanOgrenci calıskanOgrenci = new CalıskanOgrenci("Ayse", 13, 9);
        calıskanOgrenci.DurumGoster();
    }
}
