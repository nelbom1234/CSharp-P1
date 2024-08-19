namespace loop {
    public class Loop {
        public void loop() {
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
                        Console.Clear();
                        Otte();
                        Console.WriteLine("Tryk enter for at gå tilbage til menuen.");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        Ni();
                        Console.WriteLine("Tryk enter for at gå tilbage til menuen.");
                        Console.ReadKey();
                        break;
                    case 10:
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
            Console.WriteLine("\t8");
            Console.WriteLine("\t9");
            Console.WriteLine("\t10 \tTilbage til Hovedmenuen");
            
        }

        public void Et() {
            for (int i = 1; i < 11; i++) {
                Console.WriteLine(i);
            }

            int j = 1;
            while (j < 11) {
                Console.WriteLine(j);
                j++;
            }
        }

        public void To() {
            for (int i = 100; i > 0; i--) {
                Console.WriteLine(i);
            }

            int j = 100;
            while (j > 0) {
                Console.WriteLine(j);
                j--;
            }
        }

        public void Tre() {
            for (int i = 5; i < 100; i+=5) {
            Console.WriteLine(i);
            }
        }

        public void Fire() {
            //opgave beskrivelsen er lidt kringlet
            //mit beste bud er at den skal tælle ned fra 20 til 0 og udskrive, men det er bare en minder udgave af opgave 2

            for (int i = 20; i >= 0; i--) {
                Console.WriteLine(i);
            }

            int j = 20;
            while (j >= 0) {
                Console.WriteLine(j);
                j--;
            }
        }

        public void Fem() {
            for (int i = 1; i < 10; i++) {
                Console.WriteLine($"{i} * 7 = {i*7,3}");
            }
        }

        public void Seks() {
            string? result;
            int tal;

            while(true) {
                Console.WriteLine("Indtast et tal");
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

            for (int i = 1; i < 10; i++) {
                Console.WriteLine($"{i} * {tal} = {i*tal,3}");
            }
        }

        public void Syv() {
            int x1 = 20;
            int y1 = 4;
            int x2 = 30;
            int y2 = 8;

            Console.Clear();
            for (int i = x1; i <= x2; i++) {
                Console.SetCursorPosition(i,y1);
                Console.WriteLine("_");
                Console.SetCursorPosition(i, y2);
                Console.WriteLine("_");
            }

            for (int j = y1+1; j <= y2; j++) {
                Console.SetCursorPosition(x1, j);
                Console.WriteLine("|");
                Console.SetCursorPosition(x2, j);
                Console.WriteLine("|");
            }
        }

        public void Otte() {
            int x1 = 20;
            int y1 = 4;
            int x2 = 30;
            int y2 = 8;

            string navn = "Nicolai";

            Console.Clear();
            for (int i = x1; i <= x2; i++) {
                Console.SetCursorPosition(i,y1);
                Console.WriteLine("_");
                Console.SetCursorPosition(i, y2);
                Console.WriteLine("_");
            }

            for (int j = y1+1; j <= y2; j++) {
                Console.SetCursorPosition(x1, j);
                Console.WriteLine("|");
                Console.SetCursorPosition(x2, j);
                Console.WriteLine("|");
            }

            Console.SetCursorPosition(22, 6);
            Console.WriteLine(navn);
            Console.ReadKey();
            Console.Clear();
        }

        public void Ni() {
            string? result;
            int x1;
            int y1;
            int x2;
            int y2;
            string navn;

            while(true) {
                Console.WriteLine("indtast x-koordinat for the første punkt");
                result = Console.ReadLine();

                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt heltal\n");
                    continue;
                }
                if (!int.TryParse(result, out x1)) {
                    Console.WriteLine("Det er ikke et gyldigt heltal\n");
                    continue;
                }
                break;
            }

            while(true) {
                Console.WriteLine("indtast y-koordinat for the første punkt");
                result = Console.ReadLine();

                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt heltal\n");
                    continue;
                }
                if (!int.TryParse(result, out y1)) {
                    Console.WriteLine("Det er ikke et gyldigt heltal\n");
                    continue;
                }
                break;
            }

            while(true) {
                Console.WriteLine("indtast x-koordinat for the andet punkt");
                result = Console.ReadLine();

                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt heltal\n");
                    continue;
                }
                if (!int.TryParse(result, out x2)) {
                    Console.WriteLine("Det er ikke et gyldigt heltal\n");
                    continue;
                }
                break;
            }

            while(true) {
                Console.WriteLine("indtast y-koordinat for the andet punkt");
                result = Console.ReadLine();

                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt heltal\n");
                    continue;
                }
                if (!int.TryParse(result, out y2)) {
                    Console.WriteLine("Det er ikke et gyldigt heltal\n");
                    continue;
                }
                break;
            }

            while(true) {
                Console.WriteLine("indtast dit navn");
                result = Console.ReadLine();
                if (result == null) {
                    Console.WriteLine("Der er ikke noget input");
                    continue;
                }
                navn = result;
                break;
            }

            Console.Clear();
            for (int i = x1; i <= x2; i++) {
                Console.SetCursorPosition(i,y1);
                Console.WriteLine("_");
                Console.SetCursorPosition(i, y2);
                Console.WriteLine("_");
            }

            for (int j = y1+1; j <= y2; j++) {
                Console.SetCursorPosition(x1, j);
                Console.WriteLine("|");
                Console.SetCursorPosition(x2, j);
                Console.WriteLine("|");
            }

            Console.SetCursorPosition(((x2+x1+1)/2)-navn.Length/2, (y2+y1+1)/2);
            Console.WriteLine(navn);
            Console.ReadKey();
            Console.Clear();
        }
    }
}