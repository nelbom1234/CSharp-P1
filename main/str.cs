namespace str {
    public class Str {
        public void str() {
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
            int tal = 5;
            string text = "Hej med dig";
            double decimaltal = 5.9;

            Console.WriteLine(tal);
            Console.WriteLine(text);
            Console.WriteLine(decimaltal);
        }

        public void To() {
            int tal = 5;
            string text = "Hej med dig";
            double decimaltal = 5.9;

            tal = 17;

            Console.WriteLine(tal);
            Console.WriteLine(text);
            Console.WriteLine(decimaltal);
        }

        public void Tre() {
            string text = "I dag har vi den 24. December";

            Console.WriteLine(text);
        }

        public void Fire() {
            double decimaltal = 200.50;
            string text = "Jeg har";
            string text2 = "kr. i banken";

            Console.WriteLine(text + " " + $"{decimaltal:N2}" + " " + text2);
        }
    }
}