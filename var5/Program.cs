string? result;
string navn;
uint alder;

while (true) {
    Console.WriteLine("Indtast dit navn");
    result = Console.ReadLine();
    if (result == null) {
        Console.WriteLine("Det er ikke et gyldigt input\n");
        continue;
    }
    navn = result;
    break;
}

while (true) {
    Console.WriteLine("Indtast din alder");
    result = Console.ReadLine();
    try {
        if (result == null) {
            throw new Exception();
        }
        alder = uint.Parse(result);
    }
    catch {
        Console.WriteLine("Det var ikke et gyldigt heltal\n");
        continue;
    }
    break;
}

Console.WriteLine($"Jeg hedder {navn} og er {alder} år gammel.");