namespace PJATK1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrzykladyZajecia1();

            /*Napisać program, który będzie obliczać finalną cenę biletu,
             * który umożlwia wstęp do muzeum w Warszawie.
             * Podstawowa cena bilety to 40zł.
             * Znizki:
             * wiek <10 - 100%
             * wiek > 65 - 80%
             * wiek < 18 - 50%
             * miejsce zam Warszawa -> 10%
             * Na koniec chcemy wyświetlic cenę biletu
             */

            //1. Dane wejściowe
            Console.WriteLine("Wprowadź miejsce zamieszkania");
            string miejsceZamieszkania = Console.ReadLine();

            Console.WriteLine("Wprowadź swój wiek");
            string wiekStr = Console.ReadLine();
            int wiek = int.Parse(wiekStr);
            //2. Wartosc znizki
            double cenaBiletu = 40;
            double znizka = 0.0;
            if (wiek < 10)
            {
                Console.WriteLine("Cena biletu to 0 zł");
                return;
            }
            else if(wiek < 18)
            {
                znizka += 0.5;
            }
            else if(wiek > 65)
            {
                znizka += 0.8;
            }

            if(miejsceZamieszkania.ToUpper() == "WARSZAWA")
            {
                znizka += 0.1;
            }

            cenaBiletu = cenaBiletu * (1-znizka);
            Console.WriteLine("Cena biletu to " + cenaBiletu +"zł");
        }
    
        static void PrzykladyZajecia1()
        {
            //1. Liczbowe
            //1.1 Deklaracja zmiennych
            int liczbaCalkowita = 13;
            double temp = 22.5;

            liczbaCalkowita = 17;
            temp = 21.5;

            //1.2 Rzutowanie
            liczbaCalkowita = (int)temp;

            //1.3 Wyrażenia
            int w = (int)(liczbaCalkowita + temp);

            //1.4 Operacje na zmiennych zmiennoprzecinkowych
            //nie są precyzyjne
            temp = 0.2 + 0.3;

            Console.WriteLine(temp);
            Console.WriteLine("Hello, World!");

            //2. Zmienne tekstowe
            string zdanie = "Ala ma kota";
            char znak = 'a';
            znak = (char)(znak + 1);

            //2.1 Konkatenacja
            int wiek = 13;
            string opis = "Ala ma" + wiek + "lat";

            string opisDuzymiLiterami = opis.ToUpper();

            //3. Zmienne logiczne
            bool czyJestCieplo = true;
            bool czyJestZimno = temp > 35;

            //=======================================
            //Kontrola przepływu sterowana
            //1. Instrukcja warunkowa
            int wiekJana = 25;
            double tempNaZewn = 24.5;
            if (wiekJana > 18 && tempNaZewn != 20)
            {
                Console.WriteLine("Wyjscie na zewnatrz");
            }
            else if (wiekJana > 65)
            {
                Console.WriteLine("Senior");
            }
            else
            {
                Console.WriteLine("Brak wyjścia");
            }
        }
    }
}