using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main()
    {
        int padding = 40;

        // Preved text v promenne pozdrav do promenne velkyPozdrav tak, aby vsechna pismenka byla velka
        string pozdrav = "Ahoj";
        string velkyPozdrav = pozdrav.ToUpper();
        Console.WriteLine("Povedlo se prevest text na velky - ".PadRight(padding) + (velkyPozdrav == "AHOJ"));

        // Prirad do promenne orez text z promenne extraMezery, ale zbav ho extra mezer na zacatku i na konci. 
        string extraMezery = "  Vloudily se sem nejake extra mezery na zacatek a na konec. ";
        string orez = extraMezery.Trim();
        Console.WriteLine("Povedlo se orezat text - ".PadRight(padding) + (orez == "Vloudily se sem nejake extra mezery na zacatek a na konec."));

        // Do pole cisla uloz telefonni cisla, ktera ziskat z pole kontaktu. Musis projit vsechny zaznamy a postupne z nich ziskat spravnou informaci. A pozor, nektere kontakty tel. cislo mit nemuseji!
        string[] kontakty = { "Pepa Kvasek 777111888", "Honza Borec 666123987", "Karel Novak 606713827", "Tomas Kamarad" };
        string[] cisla = new string[kontakty.Length];
        string[] jmenaSeznamu = new string[kontakty.Length];
        string[] prijmeniSeznamu = new string[kontakty.Length];
       
        string[] delic = new string [3];
        for (int i = 0; i < kontakty.Length-1; i++)
        {
            delic = kontakty[i].Split(' ');
            jmenaSeznamu[i] = delic[0];
            prijmeniSeznamu[i] = delic[1];
            cisla[i] = delic[2];      
        }
        
        Console.WriteLine("Povedlo se oddelit cisla - ".PadRight(padding) + (cisla[0] == "777111888" && cisla[1] == "666123987" && cisla[2] == "606713827" && cisla[3] == null));

        // Navazuje na predchozi priklad. Ziskana telefonni cisla spoj do jedne textove promenne telCisla. Oddelena necht jsou pomoci carky s mezerou ", ".
        string telCisla = string.Join(", ", cisla);
        Console.WriteLine("Povedlo se spojit cisla - ".PadRight(padding) + (telCisla == "777111888, 666123987, 606713827, "));

        // V nasledujicim seznamu nahrad stredniky carkou s mezerou ", " a uloz do promenne opravenySeznam.
        string seznam = "batoh;boty;kratasy;tricko";
        string opravenySeznam = string.Join(", ", (seznam.Split(';')));
        Console.WriteLine("Povedlo se nahradit znaky - ".PadRight(padding) + (opravenySeznam == "batoh, boty, kratasy, tricko"));

        // Z nasledujiciho pole sestav hezky vypadajici nakupni uctenku. Produkty se zarovnaji doleva a ceny doprava tak, ze produkt a cena se spoji carkovanou linkou. Viz priklad.
        // Jablko..........10 Kc
        // Kabelka.......1000 Kc
        // Aby se reseni dalo zkontrolovat, tak kazdy radek uctenky pridej do promenne builder (typ StringBuilder) a vysledek pote uloz do promenne hezkaUctenka. 
        // Tecek dopln jen tolik, aby delka kazdeho radku byla presne 21 znaku. Rekneme, ze se muzes spolehnout, ze jmeno produktu neni delsi nez 10 znaku a cena vcetne "Kc" neni delsi nez 6 znaku.

        string[] cennik = { "hruska-10", "banan-7", "fik-12", "tunak-600", "cibule-1" };
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        string[] polozka = new string[2];

        foreach (string c in cennik) 
        {
            polozka = c.Split('-');
            builder.Append(polozka[0].PadRight(15,'.'));
            builder.AppendLine((polozka[1]+" Kc").PadLeft(6,'.'));
        }
        // tvuj kod zde

        string hezkaUctenka = builder.ToString();

        Console.WriteLine();
        Console.WriteLine(hezkaUctenka);

        string reseni = @"hruska..........10 Kc
banan............7 Kc
fik.............12 Kc
tunak..........600 Kc
cibule...........1 Kc";

        Console.WriteLine("\nReseni by melo vypadat stejne jako nasledujici ...\n\n" + reseni);

        Console.ReadLine();
    }
}