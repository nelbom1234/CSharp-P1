int x1 = 20;
int y1 = 4;
int x2 = 30;
int y2 = 8;

string navn = "Nicolai";

Console.Clear();
for (int i = x1; i <= x2; i++) {
    Console.SetCursorPosition(i,y1);
    Console.WriteLine("_");
    Console.SetCursorPosition(i, y2);
    Console.WriteLine("_");
}

for (int j = y1+1; j <= y2; j++) {
    Console.SetCursorPosition(x1, j);
    Console.WriteLine("|");
    Console.SetCursorPosition(x2, j);
    Console.WriteLine("|");
}

Console.SetCursorPosition(22, 6);
Console.WriteLine(navn);
Console.ReadKey();
Console.Clear();