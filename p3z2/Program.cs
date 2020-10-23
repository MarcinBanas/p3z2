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
            while (!CzySieUdaloA)
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
            double WyliczonaDelta = Delta(a, b, c);
            Console.WriteLine("delta:" + WyliczonaDelta);
            Wyniki MZ;
            if (WyliczonaDelta < 0)
            {
                MZ = Wyniki.BrakMiejscZerowych;
            }
            else if (WyliczonaDelta == 0)
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
                    double x1 = ((-b) / (2 * a));
                    Console.WriteLine("Funkcja posiada jedno miejsce zerowe:" + x1);
                    break;
                case Wyniki.DwaMiejscaZerowe:
                    double x2 = ((-b - WyliczonaDelta) / (2 * a));
                    double x3 = ((-b + WyliczonaDelta) / (2 * a));
                    Console.Write("Funkcja posiada dwa miejsca zerowe x1:" + x2);
                    Console.WriteLine(" x2:" + x3);
                    break;
                default:
                    Console.WriteLine("Brak Wynikow.");
                    break;
            }
        }
    }
}
