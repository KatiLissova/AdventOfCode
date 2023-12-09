/*List<int> liste = new List<int>();

liste.Add(5);
liste.Add(10);
liste.Add(55);

Console.WriteLine(liste[1]);
Console.WriteLine(liste.IndexOf(55));

string a = "Hallo";
Console.WriteLine(a.Substring(2, 1));
Console.WriteLine(a.Substring(1, 3));

Console.WriteLine("Ende");
*/

string a = "Katerina 456 Papa";
string[] b;
b = a.Split(' ');

string[] res = a.Split(':');
string data = res[1];
string gewinnnummer = data.Split('|')[0];
string meinenummer = data.Split('|')[1];
string[] gew = gewinnnummer.Split(' ', StringSplitOptions.RemoveEmptyEntries);
string[] mei = meinenummer.Split(' ', StringSplitOptions.RemoveEmptyEntries);

string[] zeilen;
zeilen = File.ReadAllLines("input.txt");
string weg = zeilen[0];

string position = "AAA";
int züge = 0;

int num = 0;
while (position!= "ZZZ"){
    int platz = 2;
    while(zeilen[platz].Substring(0, 3)!= position) {
        platz = platz + 1;
    }
    if(weg.Length == num) {
        num = 0;
    }
    char richtung=weg[num];
    if (richtung=='L') {
        position = (zeilen[platz].Substring(7, 3));
    } else {
        position = (zeilen[platz].Substring(12, 3));
    }
    züge = züge+1;
    num = num + 1;
}

Console.WriteLine(züge);