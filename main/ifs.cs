namespace ifs {
    public class Ifs {
        public void ifs() {
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
                        Console.Clear();
                        Syv();
                        Console.WriteLine("Tryk enter for at gå tilbage til menuen.");
                        Console.ReadKey();
                        break;
                    case 8:
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
            Console.WriteLine("\t7");
            Console.WriteLine("\t8 \tTilbage til Hovedmenuen");
            
        }


        public void Et() {
            int tal1 = 42;
            int tal2 = 64;

            int result = tal1 + tal2;

            if (result > 100) Console.WriteLine("Summen er større end 100!");
            else if (result < 100) Console.WriteLine("Summen er mindre end 100");
            else Console.WriteLine("Summen er 100");
        }

        public void To() {
            string? result;
            uint alder;

            while(true) {
                Console.WriteLine("Indtast din alder");
                result = Console.ReadLine();

                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt positivt heltal\n");
                    continue;
                }
                if (!uint.TryParse(result, out alder)) {
                    Console.WriteLine("Det er ikke et gyldigt positivt heltal\n");
                    continue;
                }
                break;
            }

            if (alder > 57) Console.WriteLine("Du er for gammel");
            else Console.WriteLine("Du er ikke for gammel");
        }

        public void Tre() {
            string? result;
            uint alder;

            while(true) {
                Console.WriteLine("Indtast din alder");
                result = Console.ReadLine();

                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt positivt heltal\n");
                    continue;
                }
                if (!uint.TryParse(result, out alder)) {
                    Console.WriteLine("Det er ikke et gyldigt positivt heltal\n");
                    continue;
                }
                break;
            }

            if (alder > 60) Console.WriteLine("Du er for gammel");
            else if (alder >= 50) Console.WriteLine("Du er hverken for gammel eller for ung");
            else Console.WriteLine("Du er for ung");


        }

        public void Fire() {
            string? result;
            string navn;
            string brugernavn;
            string password;
            string korrekt_brugernavn = "NIN";
            string korrekt_password = "Tec123";

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
                Console.WriteLine("Indtast dit brugernavn");
                result = Console.ReadLine();
                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt input\n");
                    continue;
                }
                brugernavn = result;
                break;
            }

            while (true) {
                Console.WriteLine("Indtast dit password");
                result = Console.ReadLine();
                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt input\n");
                    continue;
                }
                password = result;
                break;
            }

            if (brugernavn == korrekt_brugernavn && password == korrekt_password) {
                Console.WriteLine("Velkommen " + navn);
            }
            else Console.WriteLine("brugernavn eller password er forkert");
        }

        public void Fem() {
            string? result;
            string navn;
            string brugernavn;
            string password;
            string korrekt_brugernavn = "NIN";
            string korrekt_password = "Tec123";

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
                Console.WriteLine("Indtast dit brugernavn");
                result = Console.ReadLine();
                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt input\n");
                    continue;
                }
                brugernavn = result;
                break;
            }

            while (true) {

                if (brugernavn != korrekt_brugernavn) {
                    Console.WriteLine("brugernavnet er forkert");
                    break;
                }

                Console.WriteLine("Indtast dit password");
                result = Console.ReadLine();
                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt input\n");
                    continue;
                }
                password = result;
                
                if (password == korrekt_password) {
                    Console.WriteLine("Velkommen " + navn);
                }
                else Console.WriteLine("passwordet er forkert");
                break;
            }
        }

        public void Seks() {
            string? result;
            uint distance;

            while(true) {
                Console.WriteLine("Indtast hvor mange kilometer du kører hver dag til og fra arbejde");
                result = Console.ReadLine();

                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt positivt heltal\n");
                    continue;
                }
                if (!uint.TryParse(result, out distance)) {
                    Console.WriteLine("Det er ikke et gyldigt positivt heltal\n");
                    continue;
                }
                break;
            }

            if (distance <= 24) {
                Console.WriteLine("Du får ikke noget fradrag");
            }
            else if (distance <= 120) {
                Console.WriteLine($"Du får {(distance - 24) * 1.93:C} i fradrag");
            }
            else {
                Console.WriteLine($"Du får {96 * 1.93 + (distance - 120) * 0.97:C} i fradrag");
            }
        }

        public void Syv() {
            string? result;
            uint alder;

            Console.Title = "Festen";

            while (true) {
                Console.WriteLine("do you prefer red, green, blue or yellow");
                result = Console.ReadLine();
                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt input\n");
                    continue;
                }

                switch (result) {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case "blue":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    case "yellow":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        break;
                    default:
                        Console.WriteLine("Det er ikke en gyldig farve man kan vælge\n");
                        continue;
                }

                break;
            }

            while(true) {
                Console.WriteLine("\nhvor gammel er du");
                result = Console.ReadLine();

                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt positivt heltal\n");
                    continue;
                }
                if (!uint.TryParse(result, out alder)) {
                    Console.WriteLine("Det er ikke et gyldigt positivt heltal\n");
                    continue;
                }
                break;
            }

            Console.Clear();

            if (alder >= 18) {
                Console.WriteLine("velkommen til cocktailbaren");
            }
            else Console.WriteLine("velkommen til sodavandsbaren");

            Thread.Sleep(10000);
            Console.ResetColor();
            Console.Clear();
        }
    }
}