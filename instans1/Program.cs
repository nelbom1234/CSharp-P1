using classes;

var Moby = new Bog();
Moby.titel = "Moby Dick";
Moby.pris = 240;

Console.WriteLine($"{Moby.titel} - koster {Moby.pris} kr.");
Console.WriteLine(Moby.HarRåd(250)); 