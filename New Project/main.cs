using System.IO;
using System;

class Program
{
    static void Main()
    {
        
        Samochod mojSamochod = new Samochod("Ford", 5);
    
        Console.WriteLine(mojSamochod.marka + " " + mojSamochod.liczbaDrzwi);
        
        Console.WriteLine(mojSamochod.WlaczSilnik());
        
        Console.WriteLine(mojSamochod.ZmienBieg(2));
        Console.WriteLine(mojSamochod.ZmienBieg(3));
        
        Console.WriteLine(mojSamochod.Skrec("lewo"));
        Console.WriteLine(mojSamochod.Skrec("prawo"));
        
        Console.WriteLine(mojSamochod.ZatrzymajSie());
        
        //Zwierze wszystkieZwierzeta = new Zwierze();
        
        //wszystkieZwierzeta.gatunek = "podrzedne";
        //wszystkieZwierzeta.iloscLap = 4;
        
        //Console.WriteLine(wszystkieZwierzeta.gatunek);
    }
}
class Samochod
{
    public Samochod(string _marka, int _liczbaDrzwi)
    {
        marka = _marka;
        liczbaDrzwi = _liczbaDrzwi;
    }
    
    public string marka = string.Empty;
    public int liczbaDrzwi = 0;
    
    public string WlaczSilnik()
    {
        return "Silnik wlaczony";
    }
    public string ZmienBieg(int numerBiegu)
    {
        return "Wlaczono bieg numer " + numerBiegu;
    }
    public string Skrec(string kierunekSkretu)
    {
        return "skrecam w " + kierunekSkretu;
    }
    public string ZatrzymajSie()
    {
        return "Zatrzymano samochod";
    }
}
class Zwierze
{
    public string gatunek = string.Empty;
    public int iloscLap = 0;
}