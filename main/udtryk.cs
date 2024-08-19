namespace udtryk {
    public class Udtryk {
        public void udtryk() {
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
            int tal1 = 6;
            int tal2 = 7;
            int tal3 = 16;

            int result;

            result = (tal3 - tal2) % tal1;

            Console.WriteLine(result);
        }

        public void To() {
            double tal1 = 5.3;
            double tal2 = 7.2;
            double tal3 = 9.7;

            double result;

            // Mix tal og variabelnavne i udtrykkene og udskriv variablerne.(f.eks. Kim + 5) 
            //hvad i alverden betyder det ovenstående. beskrivelsen giver nul mening
            Console.WriteLine("Aner virkelig ikke hvad det er opgaven vil have mig til at udskrive");
        }
    }
}