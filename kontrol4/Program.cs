double skat = 0;
int indtægt = 500000;

if (indtægt >= 42000) {
    skat += (indtægt-42000)*0.3;
}
if (indtægt >= 280000) {
    skat += (indtægt-280000)*0.06;
}
if (indtægt >= 390000) {
    skat += (indtægt-390000)*0.15;
}

Console.WriteLine($"Der skal betales {skat:C} i skat");