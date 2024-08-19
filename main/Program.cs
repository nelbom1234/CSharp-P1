using classes;

void main() {
    string? result;
    uint menuValg;
    bool shouldExit = false;

    while (!shouldExit) {
        HovedMenu();
        result = Console.ReadLine();
        if (result == null) {
            Console.WriteLine("Inputtet skal være et positivt heltal. tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        if (!uint.TryParse(result, out menuValg)) {
            Console.WriteLine("Inputtet skal være et positivt heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        switch (menuValg) {
            case 1:
                new vari.Vari().vari();
                break;
            case 2:
                new str.Str().str();
                break;
            case 3:
                new aritmetik.Aritmetik().aritmetik();
                break;
            case 4:
                new udtryk.Udtryk().udtryk();
                break;
            case 5:
                new bools.Bools().bools();
                break;
            case 6:
                new ifs.Ifs().ifs();
                break;
            case 7:
                new switchs.Switchs().switchs();
                break;
            case 8:
                new loop.Loop().loop();
                break;
            case 9:
                new kontrol.Kontrol().kontrol();
                break;
            case 10:
                new metoder.Metoder().metoder();
                break;
            case 11:
                new retur.Retur().retur();
                break;
            case 12:
                new instans.Instans().instans();
                break;
            case 13:
                new nedarvning.Nedarvning().nedarvning();
                break;
            case 14:
                new konstruktor.Konstruktor().konstruktor();
                break;
            case 15:
                new arrays.Arrays().arrays();
                break;
            case 16:
                new gennemløb.Gennemløb().gennemløb();
                break;
            case 17:
                shouldExit = true;
                break;
            default:
                Console.WriteLine("Det er ikke et gyldigt input. Tryk enter for at gå tilbage til menuen.");
                Console.ReadKey();
                continue;
            
        }
    }
}


void HovedMenu() {
    Console.Clear();
    Console.WriteLine("Vælg et hovedemne (skriv tallet)");
    Console.WriteLine("\t1 \tVariabler");
    Console.WriteLine("\t2 \tStrings");
    Console.WriteLine("\t3 \tAritmetiske udtryk");
    Console.WriteLine("\t4 \tVariabler i udtryk");
    Console.WriteLine("\t5 \tBoolske variable");
    Console.WriteLine("\t6 \tIf-else statements");
    Console.WriteLine("\t7 \tSwitch Case");
    Console.WriteLine("\t8 \tLoops");
    Console.WriteLine("\t9 \tUdvidet konstrolstrukturerer");
    Console.WriteLine("\t10 \tMetoder og instanser");
    Console.WriteLine("\t11 \tReturtyper og parametre");
    Console.WriteLine("\t12 \tInstancevariabler");
    Console.WriteLine("\t13 \tNedarvning");
    Console.WriteLine("\t14 \tKonstruktors");
    Console.WriteLine("\t15 \tArrays");
    Console.WriteLine("\t16 \tGennemløb af arrays");
    Console.WriteLine("\t17 \tLuk programmet");
}

main();