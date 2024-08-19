using classes;

namespace metoder {
    public class Metoder {
        public void metoder() {
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
                        Console.Clear();
                        To();
                        Console.WriteLine("Tryk enter for at gå tilbage til menuen.");
                        Console.ReadKey();
                        break;
                    case 3:
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
            Console.WriteLine("\t2");
            Console.WriteLine("\t3 \tTilbage til Hovedmenuen");
            
        }


        public void Et() {
            var SherlockHolmes = new Bog();
            SherlockHolmes.PrintInfo();
        }

        public void To() {
            var SherlockHolmes = new Bog();
            if (SherlockHolmes.HarRåd(150, 200)) {
                Console.WriteLine("Jeg har råd");
            }
            else {
                Console.WriteLine("Jeg har desværre ikke råd");
            }
        }
    }
}