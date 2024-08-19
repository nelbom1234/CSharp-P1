namespace kontrol {
    public class Kontrol {
        public void kontrol() {
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
            Console.WriteLine("\t6 \tTilbage til Hovedmenuen");
            
        }


        public void Et() {
            for (int i = 1; i < 10; i++) {
                if ((i*3) == 21) {
                    break;
                }
                Console.WriteLine(i*3);
            }
            Console.WriteLine("Loopen er nu stoppet");
        }

        public void To() {
            int i = 0;

            while(i < 10) {
                i++;
                if (i*4 == 16) {
                    continue;
                }
                Console.WriteLine(i*4);
            }
            Console.WriteLine("Loopen er nu stoppet");
        }

        public void Tre() {
            //jeg kan ærligt talt ikke finde ud af hvordan jeg nogensinde skal få ||
            //til at gøre noget som helst brugbart i den her opgave

            int fradrag = 0;
            int km = 102;

            if (km >= 25 && km <= 100) {
                fradrag += (km-24)*154;
            }
            else if (km > 100) {
                fradrag += 76*154;
                fradrag += (km-100)*77;
            }

            Console.WriteLine($"Der er et fradrag på {fradrag} øre");
        }

        public void Fire() {
            double skat = 0;
            int indtægt = 500000;

            if (indtægt >= 42000) {
                skat += (indtægt-42000)*0.3;
            }
            if (indtægt >= 280000) {
                skat += (indtægt-280000)*0.06;
            }
            if (indtægt >= 390000) {
                skat += (indtægt-390000)*0.15;
            }

            Console.WriteLine($"Der skal betales {skat:C} i skat");
        }

        public void Fem() {
            string? result;
            uint penge;

            double rente;

            while(true) {
                Console.WriteLine("Hvor mange penge står der på kontoen");
                result = Console.ReadLine();

                if (result == null) {
                    Console.WriteLine("Det er ikke et gyldigt positivt heltal\n");
                    continue;
                }
                if (!uint.TryParse(result, out penge)) {
                    Console.WriteLine("Det er ikke et gyldigt positivt heltal\n");
                    continue;
                }
                break;
            }

            if (penge < 25000) {
                rente = penge * 0.25 / 100;
            }
            else if (penge <= 150000) {
                rente = penge * 1.25 / 100;
            }
            else {
                rente = (150000 * 1.25 / 100) + (penge - 150000) * 0.5 / 100;
            }

            Console.WriteLine($"Efter det første år giver det en rente på {rente:C2}");
        }
    }
}