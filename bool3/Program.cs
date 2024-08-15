string? result;
uint alder;

while(true) {
    Console.WriteLine("Indtast din alder");
    result = Console.ReadLine();

    if (result == null) {
        Console.WriteLine("Det er ikke et gyldigt positivt heltal\n");
        continue;
    }
    if (!uint.TryParse(result, out alder)) {
        Console.WriteLine("Det er ikke et gyldigt positivt heltal\n");
        continue;
    }
    break;
}

if (alder > 60) Console.WriteLine("Du er for gammel");
else if (alder >= 50) Console.WriteLine("Du er hverken for gammel eller for ung");
else Console.WriteLine("Du er for ung");

