//jeg kan ærligt talt ikke finde ud af hvordan jeg nogensinde skal få ||
//til at gøre noget som helst brugbart i den her opgave

int fradrag = 0;
int km = 102;

if (km >= 25 && km <= 100) {
    fradrag += (km-24)*154;
}
else if (km > 100) {
    fradrag += 76*154;
    fradrag += (km-100)*77;
}

Console.WriteLine($"Der er et fradrag på {fradrag} øre");