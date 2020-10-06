using System;

namespace p3z2
{
    class Program
    {
        enum Wyniki
        {
            BrakMiejscZerowych,
            JednoMiejsceZerowe,
            DwaMiejscaZerowe
        }
        static double Wczytaj()
        {
            string odpowiedz = Console.ReadLine();
            int a;
            bool CzySieUdaloA = int.TryParse(odpowiedz, out a);
            while(CzySieUdaloA==false)
            {
                    Console.WriteLine("Zle dane");
                    odpowiedz = Console.ReadLine();
                    CzySieUdaloA = int.TryParse(odpowiedz, out a);
            }
                return a;
        }
        
        static double Delta(double a, double b, double c)
        {
            double delta = (b * b) - 4 * a * c;
            return delta;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wspolczynnik a:");
            double a = Wczytaj();
            Console.WriteLine("Podaj wspolczynnik b:");
            double b = Wczytaj();
            Console.WriteLine("Podaj wspolczynnik c:");
            double c = Wczytaj();
            Console.WriteLine("delta:" + Delta(a, b, c));
            Wyniki MZ;
            if (Delta(a, b, c) < 0)
            {
                MZ = Wyniki.BrakMiejscZerowych;
            }
            else if (Delta(a, b, c) == 0)
            {
                MZ = Wyniki.JednoMiejsceZerowe;
            }
            else
            {
                MZ = Wyniki.DwaMiejscaZerowe;
            }
            switch (MZ)
            {
                case Wyniki.BrakMiejscZerowych:
                    Console.WriteLine("Funkcja nie posiada miejsc zerowych.");
                    break;
                case Wyniki.JednoMiejsceZerowe:
                    Console.WriteLine("Funkcja posiada jedno miejsce zerowe.");
                    break;
                case Wyniki.DwaMiejscaZerowe:
                    Console.WriteLine("Funkcja posiada dwa miejsca zerowe.");
                    break;
                default:
                    Console.WriteLine("Brak Wynikow.");
                    break;
            }
        }
    }
}
