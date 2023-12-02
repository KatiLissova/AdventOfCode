string[] zeilen;
zeilen = File.ReadAllLines("input.txt");
int ergebnis = 0;
int i = 0;

while (i<zeilen.Length) {
    string zeile = zeilen[i];
    int platz = 0;
    while(!char.IsDigit(zeile[platz])) {
        platz = platz + 1;
    }
    int d1 = zeile[platz] - 48;
    int platzr = zeile.Length - 1;
    while(!char.IsDigit(zeile[platzr])) {
        platzr = platzr - 1; 
    }
    int d2 = zeile[platzr] - 48;
    int zahl = d1 * 10 + d2;
    ergebnis = zahl + ergebnis;
    i = i + 1;
}

Console.WriteLine(ergebnis);

Console.WriteLine("Ende");
