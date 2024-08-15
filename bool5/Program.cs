string? result;
string navn;
string brugernavn;
string password;
string korrekt_brugernavn = "NIN";
string korrekt_password = "Tec123";

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
    Console.WriteLine("Indtast dit brugernavn");
    result = Console.ReadLine();
    if (result == null) {
        Console.WriteLine("Det er ikke et gyldigt input\n");
        continue;
    }
    brugernavn = result;
    break;
}

while (true) {

    if (brugernavn != korrekt_brugernavn) {
        Console.WriteLine("brugernavnet er forkert");
        break;
    }

    Console.WriteLine("Indtast dit password");
    result = Console.ReadLine();
    if (result == null) {
        Console.WriteLine("Det er ikke et gyldigt input\n");
        continue;
    }
    password = result;
    
    if (password == korrekt_password) {
        Console.WriteLine("Velkommen " + navn);
    }
    else Console.WriteLine("passwordet er forkert");
    break;
}
