/*
Dictionary<string, string> dict = new Dictionary<string, string> {
    {"Papa", "Pavlo"},
    {"Mama", "Maryna"},
    {"Bruder", "Leon"},
    {"Ich", "Katerina"}
};

string wer;
wer = Console.ReadLine();
string name;
name = dict[wer];
Console.WriteLine(name);
*/

Dictionary<string, string> buch = new Dictionary<string, string> {
    {"o|", "o"},
    {"o7", "l"},
    {"oF", "r"},
    {"u|", "u"},
    {"uJ", "l"},
    {"uL", "r"},
    {"r-", "r"},
    {"r7", "u"},
    {"rJ", "o"},
    {"lL", "o"},
    {"l-", "l"},
    {"lF", "u"}
};
/*
string wer;
wer = Console.ReadLine();
string name;
name = buch[wer];
Console.WriteLine(name);*/

int col = 0;
int num = 0;
string[] zeilen = File.ReadAllLines("input.txt");
while (zeilen[num][col] != 'S') {
    col=col+1;
    if (col==zeilen.Length){
        col = 0;
        num=num+1;
    }
}

Console.WriteLine(num);
Console.WriteLine(col);
string richtung;
if(zeilen[num][col+1]=='-'||zeilen[num][col+1]=='7'||zeilen[num][col+1]=='J'){
    richtung = "r";
} else {
    if(zeilen[num+1][col]=='|'||zeilen[num+1][col]=='J'||zeilen[num+1][col]=='L'){
        richtung = "u";
    } else {
        richtung = "l";
    }
}
int oft = 0;
do {
    if(richtung == "r"){
        col = col+1;
    } else {
        if (richtung == "u"){
            num = num+1;
        } else {
            if (richtung == "l"){
                col = col-1;
            } else {
                if (richtung == "o"){
                    num = num-1;
                }
            }
        }
    }
    string richt_gef = richtung+zeilen[num][col];
    if(zeilen[num][col]!='S'){
        richtung = buch[richt_gef];
    }
    oft = oft+1;
} while (zeilen[num][col]!='S');
oft = oft/2;
Console.WriteLine(oft);