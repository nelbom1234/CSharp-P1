using classes;

namespace retur {
    public class Retur {
        public void retur() {
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
            Console.WriteLine("\t5 \tTilbage til Hovedmenuen");
            
        }


        public void Et() {
            var bil = new Bil();
            bil.MotorTændt();
            bil.MotorSlukket();
        }

        public void To() {
            var bil = new Bil();
            double gas = 2.5;

            bil.FillGas(gas);
        }

        public void Tre() {
            var bil = new Bil();
            bil.FillGas(2.5, true);
        }

        public void Fire() {
            var bil = new Bil();
            double gas = bil.RemainingGas();

            Console.WriteLine(gas);
        }
    }
}