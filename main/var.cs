namespace vari {
    public class Vari {
        public void vari() {
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
                        Console.Clear();
                        Tre();
                        Console.WriteLine("Tryk enter for at gå tilbage til menuen.");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Fire();
                        Console.WriteLine("Tryk enter for at gå tilbage til menuen.");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Fem();
                        Console.WriteLine("Tryk enter for at gå tilbage til menuen.");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Seks();
                        Console.WriteLine("Tryk enter for at gå tilbage til menuen.");
                        Console.ReadKey();
                        break;
                    case 7:
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
            Console.WriteLine("\t3");
            Console.WriteLine("\t4");
            Console.WriteLine("\t5");
            Console.WriteLine("\t6");
            Console.WriteLine("\t7 \tTilbage til Hovedmenuen");
            
        }


        public void Et() {
            int tal1 = 5;
            int tal2 = 3;
            Console.WriteLine($"{tal1} \n{tal2}");
        }

        public void To() {
            int tal1 = 5;
            int tal2 = 3;
            Console.WriteLine($"Tal1 er {tal1} \nTal2 er {tal2}");
        }

        public void Tre() {
            string navn = "Søren";
            int alder = 16;
            double penge = 1234.34;

            Console.WriteLine($"Jeg hedder {navn}, er {alder} år gammel og har tjent {penge} kr. på at lappe cykler");
        }

        public void Fire() {
            double kage = 23.56;
            double øl = 34.67;
            double pølse = 65.34;

            Console.WriteLine($"Kage \t\t {kage}");
            Console.WriteLine($"Øl \t\t {øl}");
            Console.WriteLine($"Pølse \t\t {pølse}");
            Console.WriteLine($"I alt \t\t {kage+øl+pølse:N2}");
        }

        public void Fem() {
            string? result;
            string navn;
            uint alder;

            while (true) {
                Console.WriteLine("Indtast dit navn");
                result = Console.ReadLine();
                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt input\n");
                    continue;
                }
                navn = result;
                break;
            }

            while (true) {
                Console.WriteLine("Indtast din alder");
                result = Console.ReadLine();
                try {
                    if (result == null) {
                        throw new Exception();
                    }
                    alder = uint.Parse(result);
                }
                catch {
                    Console.WriteLine("Det var ikke et gyldigt heltal\n");
                    continue;
                }
                break;
            }

            Console.WriteLine($"Jeg hedder {navn} og er {alder} år gammel.");
        }

        public void Seks() {
            string? result;
            double radius;


            while(true) {
                Console.WriteLine("Indtast radius på cirklen");
                result = Console.ReadLine();
                try {
                    if (result == null) {
                        throw new Exception();
                    }
                    radius = double.Parse(result);
                }
                catch {
                    Console.WriteLine("Det er ikke et gyldigt tal\n");
                    continue;
                }
                break;
            }
            Console.WriteLine($"Radius på cirklen er: {Math.PI * Math.Pow(radius, 2)}");
        }
    }
}