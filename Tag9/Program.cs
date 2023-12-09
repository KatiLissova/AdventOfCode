string[] zeilen;
int ergebnis = 0;
int i = 0;
zeilen = File.ReadAllLines("input.txt");

/*for (int k = 0; k < 10; k = k+1) {
    Console.WriteLine(k);
}

int k = 0;
while (k < 10) {
    Console.WriteLine(k);
    k = k+1;
}*/

while(i<zeilen.Length){
    string data;
    data = zeilen[i];
    string[] teil;
    teil = data.Split(' ');

    int[, ] zahlen = new int[teil.Length, teil.Length];

    for (int j = 0; j < teil.Length; j++)
    {
        zahlen[0, j] = int.Parse(teil[j]);
    }


    for (int r = 1; r < teil.Length; r++)
    {
        int colAnzahl = teil.Length - r;
        for (int c = 0; c < colAnzahl; c++)
        {
            zahlen[r, c] = zahlen[r-1, c+1]-zahlen[r-1, c];
        }
    }
    int summe = 0;
    for (int r = 0; r < teil.Length; r++)
    {
        int c = teil.Length-1 - r;
        summe = summe + zahlen[r, c];
    }
    //ergebnis = ergebnis+summe;
    //Console.WriteLine(summe);

    int links = 0;
    for (int r = teil.Length-1; r >= 0; r--)
    {
        links = zahlen[r, 0] - links;
    }
    ergebnis = ergebnis+links;

    i = i+1;
}
 
 Console.WriteLine(ergebnis);