double decimaltal = 200.50;
string text = "Jeg har";
string text2 = "kr. i banken";

Console.WriteLine(text + " " + $"{decimaltal:N2}" + " " + text2);