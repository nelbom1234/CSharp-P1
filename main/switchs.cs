namespace switchs {
    public class Switchs {
        public static void switchs() {
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

        public static void UnderMenu() {
            Console.Clear();
            Console.WriteLine("Vælg et underemne");
            Console.WriteLine("\t1");
            Console.WriteLine("\t2");
            Console.WriteLine("\t3 \tTilbage til Hovedmenuen");
            
        }


        public static void Et() {
            string? result;
            int tal;

            while(true) {
                Console.WriteLine("\nindtast et tal mellem 1 og 6");
                result = Console.ReadLine();

                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt heltal\n");
                    continue;
                }
                if (!int.TryParse(result, out tal)) {
                    Console.WriteLine("Det er ikke et gyldigt heltal\n");
                    continue;
                }
                break;
            }

            switch(tal) {
                case 1:
                    Console.WriteLine("Du har tastet 1");
                    break;
                case 2:
                    Console.WriteLine("du har tastet 2");
                    break;
                case 3:
                    Console.WriteLine("du har tastet 3");
                    break;
                case 4:
                    Console.Clear();
                    Console.SetCursorPosition(70, 5);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("TILLYKKE DU HAR VUNDET");
                    break;
                case 5:
                    Console.WriteLine("du har tastet 5");
                    break;
                case 6:
                    Console.WriteLine("du har tastet 6");
                    break;
                default:
                    Console.WriteLine("Tallet skal være mellem 1 og 6");
                    break;
            }

                    Thread.Sleep(10000);
                    Console.ResetColor();
                    Console.Clear();
        }

        public static void To() {
           string? result;
            int tal;
            string drink = "";
            int pris = 0;

            void Menu() {
                Console.Clear();
                Console.WriteLine("Vælg en drink (skriv tallet)");
                Console.WriteLine("\t 1. Isbjørn - 15 kr.");
                Console.WriteLine("\t 2. Champagnebrus - 20 kr.");
                Console.WriteLine("\t 3. Tequila Sunrise 17 kr.");
                Console.WriteLine("\t 4. Mojito - 23 kr.");
                Console.WriteLine("\t 5. Brandbil - 15 kr.");
                Console.WriteLine("\t 6. Filur - 19 kr.");
                

            }
            while(true) {
                Menu();
                result = Console.ReadLine();

                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt heltal\n");
                    Console.WriteLine("Tryk enter for at prøve igen");
                    Console.ReadKey();
                    continue;
                }
                if (!int.TryParse(result, out tal)) {
                    Console.WriteLine("Det er ikke et gyldigt heltal\n");
                    Console.WriteLine("Tryk enter for at prøve igen");
                    Console.ReadKey();
                    continue;
                }
                break;
            }

            switch(tal) {
                case 1:
                    drink = "Isbjørn";
                    pris = 15;
                    break;
                case 2:
                    drink = "Champagnebrus";
                    pris = 20;
                    break;
                case 3:
                    drink = "Tequila sunrise";
                    pris = 17;
                    break;
                case 4:
                    drink = "Mojito";
                    pris = 23;
                    break;
                case 5:
                    drink = "Brandbil";
                    pris = 15;
                    break;
                case 6:
                    drink = "Filur";
                    pris = 19;
                    break;
                default:
                    Console.WriteLine("Vi tager kun imod værdier imellem 1 og 6");
                    break;
            }

            if (drink != "") {
                Console.WriteLine($"\nDu har bestilt en {drink}. Den koster {pris} kr.");
            }
        }
    }
}