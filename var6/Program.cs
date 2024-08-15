string? result;
double radius;


while(true) {
    Console.WriteLine("Indtast radius på cirklen");
    result = Console.ReadLine();
    try {
        if (result == null) {
            throw new Exception();
        }
        radius = double.Parse(result);
    }
    catch {
        Console.WriteLine("Det er ikke et gyldigt tal\n");
        continue;
    }
    break;
}
Console.WriteLine($"Radius på cirklen er: {Math.PI * Math.Pow(radius, 2)}");