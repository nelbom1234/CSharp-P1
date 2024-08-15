string? result;
uint distance;

while(true) {
    Console.WriteLine("Indtast hvor mange kilometer du kører hver dag til og fra arbejde");
    result = Console.ReadLine();

    if (result == null) {
        Console.WriteLine("Det er ikke et gyldigt positivt heltal\n");
        continue;
    }
    if (!uint.TryParse(result, out distance)) {
        Console.WriteLine("Det er ikke et gyldigt positivt heltal\n");
        continue;
    }
    break;
}

if (distance <= 24) {
    Console.WriteLine("Du får ikke noget fradrag");
}
else if (distance <= 120) {
    Console.WriteLine($"Du får {(distance - 24) * 1.93:C} i fradrag");
}
else {
    Console.WriteLine($"Du får {96 * 1.93 + (distance - 120) * 0.97:C} i fradrag");
}