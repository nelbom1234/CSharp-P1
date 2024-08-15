string? result;
int tal;

while(true) {
    Console.WriteLine("Indtast et tal");
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

for (int i = 1; i < 10; i++) {
    Console.WriteLine($"{i} * {tal} = {i*tal,3}");
}