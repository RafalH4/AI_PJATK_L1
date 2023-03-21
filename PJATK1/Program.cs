namespace PJATK1
{
    internal class Program
    {
        static void Main(string[] args)
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
            if (wiekJana > 18 && tempNaZewn > 20)
            {
                Console.WriteLine("Wyjscie na zewnatrz");
            }
        }
    }
}