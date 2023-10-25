using jobbagymate;
using System.Diagnostics.CodeAnalysis;
using System.Text;

var bolygok = new List<Bolygok>();
using var sr = new StreamReader(
    path: @"..\..\..\src\solsys.txt",
    encoding: Encoding.UTF8 );
while (!sr.EndOfStream) bolygok.Add(new(sr.ReadLine()));

// 3.1. feladat
Console.WriteLine("3. feladat:");
Console.WriteLine($"\t3.1: {bolygok.Count} bolygó van a naprendszerben");

// 3.2. feladat
double k = bolygok.Sum(k => k.HoldDB);
Console.WriteLine($"\t3.2: a naprendszerben egy bolygónak átlagosan {k/bolygok.Count} holdja van");

// 3.3. feladat
Console.WriteLine("\t3.3: ");
//var f = bolygok
//    .GroupBy(h => h.BolygoNev)
//    .ToDictionary(h => h.Key, hsz => hsz.Sum(h => int.Parse(h.Terfogat)));
//var f3 = f.OrderBy(z => z.Value).Last();
//Console.WriteLine($"{f3.Key}");

// 3.4. feladat
Console.Write("\t3.4: Írd be a keresett bolygó nevét: ");
string karlanc = Console.ReadLine();
int f4 = bolygok
    .Where(v => v.BolygoNev.ToLower() == karlanc.ToLower())
    .Sum(h => h.HoldDB);
if (f4 != 0) Console.WriteLine("\t\tvan ilyen bolygó a naprendszerben");
else Console.WriteLine("\t\tsajnos nincs ilyen bolygó a naprendszerben");

// 3.5. feladat
Console.Write("\t3.5: Írj be egy egész számot: ");
int szam = Convert.ToInt32 (Console.ReadLine());
foreach (var item in bolygok)
{
    if (szam>=item.HoldDB)
    {
        Console.WriteLine($"{item.BolygoNev}");
    }
}