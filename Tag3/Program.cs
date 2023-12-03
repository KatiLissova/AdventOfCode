string[] zeilen;
zeilen = File.ReadAllLines("input.txt");
int ergebnis = 0;
int i = 0;

while(i<zeilen.Length){
    int platz = 0;
    string zeile = zeilen[i]+'.';
    string zahl = "";
    while(platz<zeile.Length){
        if (char.IsDigit(zeile[platz])) {
            zahl = zahl + zeile[platz];
        } else {
            if (zahl != "") {
                int zeichenanzahl = 0;
                if(!char.IsDigit(zeile[platz]) && zeile[platz] != '.'){
                    zeichenanzahl = zeichenanzahl + 1;
                }
                int links = platz-zahl.Length-1;
                if (links == -1) { 
                    links = 0;
                }

                if(!char.IsDigit(zeile[links]) && zeile[links] != '.'){
                    zeichenanzahl = zeichenanzahl + 1;
                }

                if (i > 0) {
                    string zeile_v = zeilen[i-1];
                    int platz1 = links;
                    while(platz1<platz+1 && platz1 < zeile_v.Length){
                        if(!char.IsDigit(zeile_v[platz1]) && zeile_v[platz1] != '.'){
                            zeichenanzahl = zeichenanzahl + 1;
                        }
                        platz1 = platz1 + 1;
                    }
                }

                if (i < zeilen.Length-1) {
                    string zeile_n = zeilen[i+1];
                    int platz1 = links;
                    while(platz1<platz+1 && platz1 < zeile_n.Length){
                        if(!char.IsDigit(zeile_n[platz1]) && zeile_n[platz1] != '.'){
                            zeichenanzahl = zeichenanzahl + 1;
                        }
                        platz1 = platz1 + 1;
                    }
                }

                if(zeichenanzahl >= 1){
                    ergebnis = ergebnis + int.Parse(zahl);
                }
                zahl = "";
            }
        }

        platz = platz + 1;
    }
    i = i + 1;
}
Console.WriteLine(ergebnis);
/*
  &&   UND
  ||   ODER
  !    NICHT/nein
*/