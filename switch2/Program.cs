string? result;
int tal;
string drink = "";
int pris = 0;

void Menu() {
    Console.Clear();
    Console.WriteLine("Vælg en drink (skriv tallet)");
    Console.WriteLine("\t 1. Isbjørn - 15 kr.");
    Console.WriteLine("\t 2. Champagnebrus - 20 kr.");
    Console.WriteLine("\t 3. Tequila Sunrise 17 kr.");
    Console.WriteLine("\t 4. Mojito - 23 kr.");
    Console.WriteLine("\t 5. Brandbil - 15 kr.");
    Console.WriteLine("\t 6. Filur - 19 kr.");
    

}
while(true) {
    Menu();
    result = Console.ReadLine();

    if (result == null) {
        Console.WriteLine("Det er ikke et gyldigt heltal\n");
        Console.WriteLine("Tryk enter for at prøve igen");
        Console.ReadKey();
        continue;
    }
    if (!int.TryParse(result, out tal)) {
        Console.WriteLine("Det er ikke et gyldigt heltal\n");
        Console.WriteLine("Tryk enter for at prøve igen");
        Console.ReadKey();
        continue;
    }
    break;
}

switch(tal) {
    case 1:
        drink = "Isbjørn";
        pris = 15;
        break;
    case 2:
        drink = "Champagnebrus";
        pris = 20;
        break;
    case 3:
        drink = "Tequila sunrise";
        pris = 17;
        break;
    case 4:
        drink = "Mojito";
        pris = 23;
        break;
    case 5:
        drink = "Brandbil";
        pris = 15;
        break;
    case 6:
        drink = "Filur";
        pris = 19;
        break;
    default:
        Console.WriteLine("Vi tager kun imod værdier imellem 1 og 6");
        Environment.Exit(0);
        break;
}

if (drink != "") {
    Console.WriteLine($"\nDu har bestilt en {drink}. Den koster {pris} kr.");
}