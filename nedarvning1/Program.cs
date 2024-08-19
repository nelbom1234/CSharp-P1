using classes;

var stol = new Chair();
stol.pris = 500;
stol.ben = 4;

var comp = new Computer();
comp.pris = 2000;
comp.cores = 6;

Console.WriteLine($"Stolen koster {stol.pris} kr. og har {stol.ben} ben");
Console.WriteLine($"Computeren koster {comp.pris} kr. og har {comp.cores} cores");