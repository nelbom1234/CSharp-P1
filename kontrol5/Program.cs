string? result;
uint penge;

double rente;

while(true) {
    Console.WriteLine("Hvor mange penge står der på kontoen");
    result = Console.ReadLine();

    if (result == null) {
        Console.WriteLine("Det er ikke et gyldigt positivt heltal\n");
        continue;
    }
    if (!uint.TryParse(result, out penge)) {
        Console.WriteLine("Det er ikke et gyldigt positivt heltal\n");
        continue;
    }
    break;
}

if (penge < 25000) {
    rente = penge * 0.25 / 100;
}
else if (penge <= 150000) {
    rente = penge * 1.25 / 100;
}
else {
    rente = (150000 * 1.25 / 100) + (penge - 150000) * 0.5 / 100;
}

Console.WriteLine($"Efter det første år giver det en rente på {rente:C2}");