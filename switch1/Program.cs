string? result;
int tal;

while(true) {
    Console.WriteLine("\nindtast et tal mellem 1 og 6");
    result = Console.ReadLine();

    if (result == null) {
        Console.WriteLine("Det er ikke et gyldigt heltal\n");
        continue;
    }
    if (!int.TryParse(result, out tal)) {
        Console.WriteLine("Det er ikke et gyldigt heltal\n");
        continue;
    }
    break;
}

switch(tal) {
    case 1:
        Console.WriteLine("Du har tastet 1");
        break;
    case 2:
        Console.WriteLine("du har tastet 2");
        break;
    case 3:
        Console.WriteLine("du har tastet 3");
        break;
    case 4:
        Console.Clear();
        Console.SetCursorPosition(70, 5);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("TILLYKKE DU HAR VUNDET");
        break;
    case 5:
        Console.WriteLine("du har tastet 5");
        break;
    case 6:
        Console.WriteLine("du har tastet 6");
        break;
    default:
        Console.WriteLine("Tallet skal være mellem 1 og 6");
        break;
}

        Thread.Sleep(10000);
        Console.ResetColor();
        Console.Clear();
        Environment.Exit(0);