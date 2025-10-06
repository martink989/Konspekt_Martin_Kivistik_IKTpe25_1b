/*

//1. tuvasta sisu võrdluses tühja stringiga, string andmetüüp
Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?:");
string nimi = Console.ReadLine();

if (nimi == "")
{
   Console.WriteLine("Sa ei sisestanud oma nime, sadface 😔");
}
else if (nimi != "")
{
   Console.WriteLine("Tere "+nimi+"! häpifeiss 😀😀 おはよう");
}
else
{
   Console.WriteLine("Tundmatu sisestus.");
}
//2 - vahemikud
Console.WriteLine(nimi+", mis on sinu vanus?:");
int kasutajavanus = int.Parse(Console.ReadLine());

//2.1 mitu tingimust pesastatud ifide abil
//if (kasutajavanus > 0)
//{
//    if (kasutajavanus < 18)
//    {
//        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😔");
//    }
//    else
//    {
//        Console.WriteLine("Yippie! saad monsut osta 😀⭐✨");
//    }
//}

//2.2 mitu tingimust kasutades loogilist tehet "and"
if (kasutajavanus > 0 && kasutajavanus < 18)
{
   Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😔");
}
else
{
   Console.WriteLine("Yippie! saad monsut osta 😀⭐✨");
}

//2.3 mitu vahemikku if/else-if abil. andmetüüp double/float/decimal
Console.WriteLine($"Sisesta oma pikkus ka {nimi}!");
double kasutajaPikkus = double.Parse(Console.ReadLine());

if (kasutajaPikkus < 1.00d)
{
   Console.WriteLine("Oled juntsu (Keemstar)");
}
else if (kasutajaPikkus < 1.25d && kasutajaPikkus >= 1.00d)
{
   Console.WriteLine("Oled peaaegu allameetrimees");
}
else if (kasutajaPikkus < 1.50d && kasutajaPikkus >= 1.25d)
{
   Console.WriteLine("OIOI, päkapikk enam ei olegi, "+nimi);
}
else if (kasutajaPikkus < 1.75d && kasutajaPikkus >= 1.5d)
{
   Console.WriteLine(nimi+", oled enamasti standardpikkuses, kui mitte just natuke lühike");
}
else if (kasutajaPikkus < 2.00d && kasutajaPikkus >= 1.75d)
{
   Console.WriteLine(nimi+", oled pikk kolge, vaata et sa pead vastu uksepiita ära ei löö 😏'");
}
else
{
   Console.WriteLine("Täielik tulnukas! Kuidas pilved välja näevad lähedalt?");
}

//3. kalkulaator ifi ja else-ifiga, int ja string andmetüübid
Console.WriteLine("tere, sisesta esimene liidetav arv");
int arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("tere, sisesta teine liidetav arv");
int arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("sisesta tehemärk: / * + - ^");
string tehtetyyp = Console.ReadLine();

int tulemus = 0;
if (tehtetyyp == "+")
{
   tulemus = arv1 + arv2;
}
if (tehtetyyp == "-")
{
   tulemus = arv1 - arv2;
}
if (tehtetyyp == "*")
{
   tulemus = arv1 * arv2;
}
if (tehtetyyp == "/")
{
   tulemus = arv1 / arv2;
}
if (tehtetyyp == "^")
{
   tulemus = (int)Math.Pow(arv1, arv2);
}

Console.WriteLine(tulemus);

//4 parool, if ja string andmetüüp
Console.WriteLine($"Palun vabandust {nimi}, aga programmi edasiseks tööks on parooli vaja");
string password = Console.ReadLine();
if (password == "simsalabim")
{
   Console.WriteLine("JES, parool on õige, oled sisse lubatud");
}
else if (password == "saatana" || password == "1234")
{
   Console.WriteLine("Parool on sobimatu, see sinu parool kohe kindlasti ei ole.");
}
else
{
   Console.WriteLine("Parool on vale");
}

//5 värvituvastus värvidele: punane oranz kollane roheline
// helesinine tumesinine lilla roosa pruun must ja valge
Console.WriteLine("Mis on sinu lemmikvärv?:");
string favColour = Console.ReadLine();
if (favColour == "punane")
{
   Console.BackgroundColor = ConsoleColor.Red;
}
else if (favColour == "oranz")
{
   Console.WriteLine("Kahjuks ei ole oranz saadaval");
}
else if (favColour == "kollane")
{
   Console.BackgroundColor = ConsoleColor.Yellow;
}
else if (favColour == "roheline")
{
   Console.BackgroundColor = ConsoleColor.DarkGreen;
}
else if (favColour == "helesinine")
{
   Console.BackgroundColor = ConsoleColor.Cyan;
}
else if (favColour == "tumesinine")
{
   Console.BackgroundColor = ConsoleColor.Blue;
}
else if (favColour == "lilla")
{
   Console.BackgroundColor = ConsoleColor.DarkCyan;
}
else if (favColour == "roosa")
{
   Console.WriteLine("Kahjuks roosat anda ei ole");
}
else if (favColour == "pruun")
{
   Console.BackgroundColor = ConsoleColor.DarkYellow;
}
else if (favColour == "must")
{
   Console.BackgroundColor = ConsoleColor.Black;
   Console.ForegroundColor = ConsoleColor.White;
}
else if (favColour == "must")
{
   Console.BackgroundColor = ConsoleColor.White;
   Console.ForegroundColor = ConsoleColor.Black;
}
else
{
   Console.WriteLine("ei tea seda värvi");
}
Console.WriteLine("The colour has maybe changed!!!!!");
*/
/* ISESEISEV ÜLESANNE */

//# Kolija kalkulaator - Kirjuta programm mis:
//#    - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
using System.Runtime.CompilerServices;

Console.WriteLine("Kas tahad mõõta ära kasti või tünni?");
string valik = Console.ReadLine();
//#    - olenevalt kasutaja sisestusest küsib ta:
if (valik == "tünn")
{

    //#    - - tünni jaoks:
    //#    - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
    Console.WriteLine("Kas sa tead tünni raadiust (r) või põhja läbimõõtu (d)");
    string rvõid = Console.ReadLine();
    Console.WriteLine("Sisesta see mõõt:");
    double mõõt = double.Parse(Console.ReadLine());
    if (rvõid == "d")
    {
        mõõt = mõõt / 2;
    }
    else if (rvõid != "r")
    {
        Console.WriteLine("Sisend ei ole tuntav");
    }

    //#    - - - tünni kõrgust
    Console.WriteLine("Kui kõrge on su tünn");
    int kõrgus = int.Parse(Console.ReadLine());

    //#    - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
    Console.WriteLine("kui paks on tünni kaas?");
    int kaanepaksus = int.Parse(Console.ReadLine());

    //#    - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
    double tünnipõhiS = Math.PI * (mõõt * mõõt);
    double mahtV = tünnipõhiS * (kõrgus - kaanepaksus);
    double küljepindala = tünnipõhiS * kõrgus;
    double kogupindala = (tünnipõhiS * 2) + küljepindala;
    Console.WriteLine($"Sinu tünn mahutab {mahtV} \nTünni küljepindala on {küljepindala} \nKogupindala aga on{kogupindala}");
}
//#    - - kasti jaoks:
else if (valik == "kast")
{
    //#    - - - Kas kast on kuubiku kujuline või risttahuka kujuline
    Console.WriteLine("Kas su kast on kuubik (k) või risttahukas (r)? ");
    string kastitüüp = Console.ReadLine();
    if (kastitüüp == "k")
    {
        //#    - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
        Console.WriteLine("Sisesta kasti küljepikkus:");
        double külgA = double.Parse(Console.ReadLine());
        double kuubik = Math.Pow(külgA, 3);
        double küljepindala = (külgA * külgA) * 6;
        double diagonaal = külgA * Math.Sqrt(3);
        Console.WriteLine($"Sinu kuubik mahutab {kuubik} \nKuubiku küljepindala on {küljepindala} \nDiagonaal aga on{diagonaal}");
    }
    //#    - - - - kui on risttahukas siis küsib kasutajalt:
    else if (kastitüüp == "r")
    {
        //#    - - - - - pikima külje pikkust, 
        Console.WriteLine("Mis on sinu kasti kõige pikim külg?:");
        double pikkKülg = double.Parse(Console.ReadLine());

        //#    - - - - - lühima külje pikkust ja
        Console.WriteLine("Mis on sinu kasti kõige lühim külg?:");
        double lühikekülg = double.Parse(Console.ReadLine());

        //#    - - - - - kasti kõrgust
        Console.WriteLine("Mis on sinu kasti kõrgus?:");
        double kõrgus = double.Parse(Console.ReadLine());

        //#    - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)
        double V = pikkKülg * lühikekülg * kõrgus;
        double kogupindala = 2 * ((pikkKülg * lühikekülg) + (lühikekülg * kõrgus) + (pikkKülg * kõrgus));
        double diagonaal = Math.Sqrt((pikkKülg * pikkKülg) + (lühikekülg * lühikekülg) + (kõrgus * kõrgus));
        Console.WriteLine($"Sinu kast mahutab {V} \nKasti küljepindala on {kogupindala} \nDiagonaal aga on{diagonaal}");
    }

}

Console.WriteLine("banana");
// Console -> adresseritav moodul või objekt (Roheline)
// . -> midagi selle objekti seest, sarnane windowsi kausta pathis oleva slashiga
//    - komakohtadega andmetüüpidel komakoha tähistamine.
// WriteLine -> adresseritav funktsioon objektist Console
// () -> sulupaar mis omab endas funktsioonile vajalikku infot
//     - saab kasutada ka if tingimuslauses oleva tingimuse piiramiseks, ehk teisiõnu "ifi parameeter"
//     - kasutatakse ka matemaatilistes tehetes
// [] -> tähistab massiive
// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.
//     - saab ka kasutada teksti sees muutujate kuvamiseks
// -> taane aitab arendajal aru saada millise koodiploki sees, miski on. Vajalik ka kompilaatorile.
// "banana" -> parameeter mis antakse funktsioonile WriteLine töötlemiseks kaasa.
// ; -> iga koodilause lõppeb komakooloniga
// // -> kommentaaritingmärk üherealise kommentaari jaoks (kaks / märki)

int muutuja = 3;
// int -> muutuja nime ees olev andmetüübi kirjeldus. See näitab ära mis tüüpi andmed selle muutuja sees on
// = -> võrdusmärk omistab sellele muutujale mingisuguse väärtuse
// 3 -> väärtus mis sellele muutujale omistatakse

//võimalikud andmetüübid:
int a = 1; // täisarv
decimal b = 2.0M; // kümnendsüsteemis olev komakohaga arv
float c = 3.0f; // kümnendsüsteemis olev ujukomaga arv
double d = 4.0d; // kümnendsüsteemis olev komakohaga arv, sarnane decimaliga
char c1 = 'a'; // üksainus täht või tähemärk
string s = "tekst"; // inimloetaval kujul tekst
var x = "abc"; // ebamäärase tüübiga kohalik muutuja. 
var y = 123;
const int z = 3; // konstant-tüüpi muutujaid ei saa muuta, need on read-only

//põhilised matemaatilised tehted
int liitmine = 1 + 1; // liitmine, kaks arvu kokku
int lahutamine = 1 - 1; // lahutamine, esimene arv maha teisest
int korrutamine = 1 * 1; //korrutamine, esimene arv korrutatakse teisega
int jagamine = 1 / 1; //jagamine, esimene arv jagatakse teisega
double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
double juurimine = Math.Sqrt(2); //ruutjuur, parameetriks arv mida juuritakse

//Kodune ülesanne, kasutades süntaksiseletust, kirjelda kommentaariga iga koodirida
Console.WriteLine("tere, sisesta esimene liidetav arv");
//Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum mis asub
//funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga
int arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("tere, sisesta teine liidetav arv");
int arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("sisesta tehemärk: / * + - ^");
string tehtetyyp = Console.ReadLine();

int tulemus = 0;
if (tehtetyyp == "+")
{
    tulemus = arv1 + arv2;
}
if (tehtetyyp == "-")
{
    tulemus = arv1 - arv2;
}
if (tehtetyyp == "*")
{
    tulemus = arv1 * arv2;
}
if (tehtetyyp == "/")
{
    tulemus = arv1 / arv2;
}
if (tehtetyyp == "^")
{
    tulemus = (int)Math.Pow(arv1, arv2);
}

Console.WriteLine(tulemus);

int arv = 0;
string sõne = "abc";
//string string = "abc";

// muutuja nimeks ei sobi järgnevad sõnad
//abstract, as, base, bool, break, byte, case,
//catch, char, checked, class, const, continue, decimal,
//default, delegate, do, double, else, enum, event,
//explicit, extern, false, finaly, fixed, float, for
//foreach, goto, if, implicit, in, int,
//interface, internal, is, lock, long, namespace, new,
//null, object, operator, out, override, params,
//private, protected, public, readonly, ref, return, sbyte
//sealed, short, sizeof, stackalloc, static, string, struct,
//switch, this, throw, true, try, typeof, uint,
//ulong, unchecked, unsafe, ushort, using, virtual, void,
//volatile, while.