string? result;
int x1;
int y1;
int x2;
int y2;
string navn;

while(true) {
    Console.WriteLine("indtast x-koordinat for the første punkt");
    result = Console.ReadLine();

    if (result == null) {
        Console.WriteLine("Det er ikke et gyldigt heltal\n");
        continue;
    }
    if (!int.TryParse(result, out x1)) {
        Console.WriteLine("Det er ikke et gyldigt heltal\n");
        continue;
    }
    break;
}

while(true) {
    Console.WriteLine("indtast y-koordinat for the første punkt");
    result = Console.ReadLine();

    if (result == null) {
        Console.WriteLine("Det er ikke et gyldigt heltal\n");
        continue;
    }
    if (!int.TryParse(result, out y1)) {
        Console.WriteLine("Det er ikke et gyldigt heltal\n");
        continue;
    }
    break;
}

while(true) {
    Console.WriteLine("indtast x-koordinat for the andet punkt");
    result = Console.ReadLine();

    if (result == null) {
        Console.WriteLine("Det er ikke et gyldigt heltal\n");
        continue;
    }
    if (!int.TryParse(result, out x2)) {
        Console.WriteLine("Det er ikke et gyldigt heltal\n");
        continue;
    }
    break;
}

while(true) {
    Console.WriteLine("indtast y-koordinat for the andet punkt");
    result = Console.ReadLine();

    if (result == null) {
        Console.WriteLine("Det er ikke et gyldigt heltal\n");
        continue;
    }
    if (!int.TryParse(result, out y2)) {
        Console.WriteLine("Det er ikke et gyldigt heltal\n");
        continue;
    }
    break;
}

while(true) {
    Console.WriteLine("indtast dit navn");
    result = Console.ReadLine();
    if (result == null) {
        Console.WriteLine("Der er ikke noget input");
        continue;
    }
    navn = result;
    break;
}

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

Console.SetCursorPosition(((x2+x1+1)/2)-navn.Length/2, (y2+y1+1)/2);
Console.WriteLine(navn);
Console.ReadKey();
Console.Clear();