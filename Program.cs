using CA230525;
using System.Text;

List<Eredmeny> eredmenyek = new();

//https://learn.microsoft.com/en-us/windows/win32/intl/code-page-identifiers

//LINQ

using StreamReader sr = new(
    path: "C:\\Users\\kabinet120\\source\\repos\\CA230525\\src\\helsinki.txt",
    encoding: Encoding.Latin1);
while(!sr.EndOfStream)
{
    string beolvasottSor = sr.ReadLine();
    Eredmeny eredmeny = new(beolvasottSor);
    eredmenyek.Add(eredmeny);
}

Console.WriteLine("3. feladat:");
Console.WriteLine($"Pontszerző helyezések száma: {eredmenyek.Count}");

int arany = eredmenyek.Count(e => e.Helyezes == 1);
int ezust = eredmenyek.Count(e => e.Helyezes == 2);
int bronz = eredmenyek.Count(e => e.Helyezes == 3);

Console.WriteLine("4. feladat:\n" +
    $"arany: {arany}\n" +
    $"ezüst: {ezust}\n" +
    $"bronz: {bronz}\n" +
    $"összesen: {arany+ezust+bronz}");

Console.WriteLine("5. feladat:\n" +
    $"Olimpiai pontok összesen: {eredmenyek.Sum(e => e.OlimpiaiPont)}");

Console.WriteLine("6. feladat:");
int torna = eredmenyek.Count(e => e.Sportag == "torna");
int uszas = eredmenyek.Count(e => e.Sportag == "uszas");
if (torna == uszas) Console.WriteLine($"Egyenlő az érmek száma");
else Console.WriteLine($"{(torna > uszas ? "torna" : "úszás")} sportágban volt több az érmek száma");

using StreamWriter sw = new(
    path: "C:\\Users\\kabinet120\\source\\repos\\CA230525\\src\\helsinki2.txt",
    append: false,
    encoding: Encoding.Latin1);

foreach (var er in eredmenyek)
{
    sw.WriteLine($"{er.Helyezes} {er.SportolokSzama} {er.OlimpiaiPont} " +
        $"{(er.Sportag == "kajakkenu" ? "kajak-kenu" : er.Sportag)} {er.Versenyszam}");
}

Eredmeny e = eredmenyek.MaxBy(e => e.SportolokSzama);
Console.WriteLine("8. feladat:\n" +
    $"Helyezés: {e.Helyezes}\n" +
    $"Sportág: {e.Sportag}\n" +
    $"Versenyszám: {e.Versenyszam}\n" +
    $"Sportolók száma: {e.SportolokSzama}");

//int a = 0;
//int e = 0;
//int b = 0;
//foreach (var eredmeny in eredmenyek)
//{
//    if (eredmeny.Helyezes == 1) a++;
//    else if (eredmeny.Helyezes == 2) e++;
//    else if (eredmeny.Helyezes == 3) b++;
//}
//Console.WriteLine("4. feladat:");
//Console.WriteLine($"Arany: {a}");
//Console.WriteLine($"Ezüst: {e}");
//Console.WriteLine($"Bronz: {b}");
//Console.WriteLine($"Összesen: {a + e + b}");

//int osszpont = 0;
//foreach (var eredmeny in eredmenyek)
//{
//    osszpont += eredmeny.OlimpiaiPont;
//}
//Console.WriteLine("5. feladat:");
//Console.WriteLine($"Olimpiai pontok száma: {osszpont}");

//int tor = 0;
//int usz = 0;
//foreach (var eredmeny in eredmenyek)
//{
//    if (eredmeny.Sportag == "torna") tor++;
//    else if (eredmeny.Sportag == "uszas") usz++;
//}
//Console.WriteLine($"6. feladat:");
//if (tor > usz) Console.WriteLine("Torna sportágban szereztek több érmet");
//else if (tor  < usz) Console.WriteLine("Úszás sportágban szereztek több érmet");
//else Console.WriteLine("Egyenlő volt az érmek száma");

//using StreamWriter sw = new(
//    path: "C:\\Users\\kabinet120\\source\\repos\\CA230525\\src\\helsinki2.txt",
//    append: false,
//    encoding: Encoding.Latin1);
//foreach (var eredmeny in eredmenyek)
//{
//    int h = eredmeny.Helyezes;
//    int ssz = eredmeny.SportolokSzama;
//    int op = eredmeny.OlimpiaiPont;
//    string san = eredmeny.Sportag;
//    if (san == "kajakkenu") san = "kajak-kenu";
//    string vszn = eredmeny.Versenyszam;

//    sw.WriteLine($"{h} {ssz} {op} {san} {vszn}");
//}

//int maxi = 0;
//for (int i = 1; i < eredmenyek.Count; i++)
//{
//    if (eredmenyek[i].SportolokSzama > eredmenyek[maxi].SportolokSzama)
//    {
//        maxi = i;
//    }
//}
//Console.WriteLine("8. feladat:");
//Console.WriteLine($"Helyezés: {eredmenyek[maxi].Helyezes}");
//Console.WriteLine($"Sportág: {eredmenyek[maxi].Sportag}");
//Console.WriteLine($"Versenyszám: {eredmenyek[maxi].Versenyszam}");
//Console.WriteLine($"Sportolók száma: {eredmenyek[maxi].SportolokSzama}");