using Konyv;

List<Konyvek> konyvek = new List<Konyvek>();

if (File.Exists("konyvek.txt"))
{
    foreach(string aktsor in File.ReadAllLines("konyvek.txt"))
    {
        string[] adatok = aktsor.Split(';');
        string azonosito = adatok[0];
        string szerzo = adatok[1];
        string cim = adatok[2];
        int db = adatok.Count();
        if (db != 5) continue;
        if (int.TryParse(adatok[3], out int ar) && int.TryParse(adatok[4], out int raktarKeszlet))
        {
            if (!string.IsNullOrWhiteSpace(adatok[0]))
            {
                Konyvek aktualis = new Konyvek(azonosito, szerzo, cim, ar, raktarKeszlet);
                konyvek.Add(aktualis);

            }
        }
        else
        {
            Console.WriteLine($"[HIBA] A(z) {azonosito} azonosítójú sor adata hibás, átugorva! ");
        }
    }
}

Console.WriteLine("\n=== BEOLVASOTT KÖNYVEK ===");
foreach (Konyvek k in konyvek)
{
    Console.WriteLine(k);
}

Console.WriteLine($"\nRegisztrált könyvek száma a rendszerben: {Konyvek.OsszesRegisztraltKonyv} db");

int osszesen = 0;
foreach(Konyvek k in konyvek)
{
    osszesen += k.Ar * k.RaktarKeszlet;
}

Console.WriteLine(($"A raktárkészlet teljes bruttó értéke (5% ÁFÁ-val): {Penzugy.BruttoArSzamitas(osszesen)} Ft"));

Konyvek legolcsobbKonyv = konyvek[0];

foreach (Konyvek k in konyvek)
{
    if (k.Ar < legolcsobbKonyv.Ar)
    {
        legolcsobbKonyv = k;
    }
}

Console.WriteLine($"Legolcsóbb könyv: {legolcsobbKonyv.Cim} ({legolcsobbKonyv.Ar} Ft)");