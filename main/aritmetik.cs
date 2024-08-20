namespace aritmetik {
    public class Aritmetik {
        public static void aritmetik() {
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

        public static void UnderMenu() {
            Console.Clear();
            Console.WriteLine("Vælg et underemne");
            Console.WriteLine("\t1");
            Console.WriteLine("\t2 \tTilbage til Hovedmenuen");
            
        }


        public static void Et() {
            int et = 2 + 1 * 2;
            int to = (2+1) * 2;
            double tre = (double)5/2;
            int fire = 8 % 3;
            int fem = 1-5;

            Console.WriteLine(et);
            Console.WriteLine(to);
            Console.WriteLine(tre);
            Console.WriteLine(fire);
            Console.WriteLine(fem);
        }

    }
}