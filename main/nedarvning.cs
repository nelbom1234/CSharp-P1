using classes;

namespace nedarvning {
    public class Nedarvning {
        public void nedarvning() {
            string? result;
            uint menuValg;
            bool shouldExit = false;

            while (!shouldExit) {
                UnderMenu();
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
                        Console.Clear();
                        Et();
                        Console.WriteLine("Tryk enter for at gå tilbage til menuen.");
                        Console.ReadKey();
                        break;
                    case 2:
                        shouldExit = true;
                        break;
                    default:
                        Console.WriteLine("Det er ikke et gyldigt input. Tryk enter for at gå tilbage til menuen.");
                        Console.ReadKey();
                        continue;
                    
                }
            }
        }

        public void UnderMenu() {
            Console.Clear();
            Console.WriteLine("Vælg et underemne");
            Console.WriteLine("\t1");
            Console.WriteLine("\t2 \tTilbage til Hovedmenuen");
            
        }


        public void Et() {
            var stol = new Chair();
            stol.pris = 500;
            stol.ben = 4;

            var comp = new Computer();
            comp.pris = 2000;
            comp.cores = 6;

            Console.WriteLine($"Stolen koster {stol.pris} kr. og har {stol.ben} ben");
            Console.WriteLine($"Computeren koster {comp.pris} kr. og har {comp.cores} cores");
        }
    }
}