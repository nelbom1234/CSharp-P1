namespace gennemløb {
    public class Gennemløb {
        public void gennemløb() {
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
            int[] arr = { 5, 2, 7, 9, 12, 4 };

            int sum = 0;
            foreach (int tal in arr) {
                sum += tal;
            }
            Console.WriteLine(sum);

            string[] arr2 = { "Hej med dig", "Mit navn er Nicolai", "Hvad hedder du", "Hvor gammel er du", "Farvel" };

            foreach (string str in arr2) {
                Console.WriteLine(str);
            }
        }
    }
}