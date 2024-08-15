string? result;
uint alder;

Console.Title = "Festen";

while (true) {
    Console.WriteLine("do you prefer red, green, blue or yellow");
    result = Console.ReadLine();
    if (result == null) {
        Console.WriteLine("Det er ikke et gyldigt input\n");
        continue;
    }

    switch (result) {
        case "red":
            Console.BackgroundColor = ConsoleColor.Red;
            break;
        case "green":
            Console.BackgroundColor = ConsoleColor.Green;
            break;
        case "blue":
            Console.BackgroundColor = ConsoleColor.Blue;
            break;
        case "yellow":
            Console.BackgroundColor = ConsoleColor.Yellow;
            break;
        default:
            Console.WriteLine("Det er ikke en gyldig farve man kan vælge\n");
            continue;
    }

    break;
}

while(true) {
    Console.WriteLine("\nhvor gammel er du");
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

Console.Clear();

if (alder >= 18) {
    Console.WriteLine("velkommen til cocktailbaren");
}
else Console.WriteLine("velkommen til sodavandsbaren");

Thread.Sleep(10000);
Console.ResetColor();
Console.Clear();
Environment.Exit(0);