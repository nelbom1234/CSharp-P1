using classes;

var bog1 = new Bog(250, "Tarzan");
var bog2 = new Bog(300);

Console.WriteLine($"{bog1.titel} koster {bog1.pris} kr.");
Console.WriteLine($"den anden bog koster {bog2.pris} kr.");