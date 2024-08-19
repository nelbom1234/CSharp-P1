int i = 0;

while(i < 10) {
    i++;
    if (i*4 == 16) {
        continue;
    }
    Console.WriteLine(i*4);
}
Console.WriteLine("Loopen er nu stoppet");