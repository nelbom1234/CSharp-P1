namespace classes {
    public class Bog {
        public Bog(int pris, string titel) {
            _pris = pris;
            _titel = titel;
        }
        public Bog(int pris) {
            _pris = pris;
            _titel = "";
        }
        public Bog() {
            _pris = 0;
            _titel = "";
        }

        public int _pris { get; set; }
        public string _titel { get; set; }
        public void PrintInfo() {
            Console.WriteLine("Jeg er en bog");
        }

        public bool HarRåd(int pris, int penge) {
            return pris <= penge;
        }

        public bool HarRåd(int penge) {
            return _pris <= penge;
        }
    }

    public class Bil {
        public void MotorTændt() {
            Console.WriteLine("Motoren er startet");
        }
        public void MotorSlukket() { 
            Console.WriteLine("Motoren er slukket");
        }
        public void FillGas(double liters) {
            Console.WriteLine("Filled tank with: " + liters + " liters");
        }
        public void FillGas(double liters, bool isDiesel) {
            Console.WriteLine("Filled tank with: " + liters + " liters of " + (isDiesel ? "diesel" : "benzin"));
        }
        public double RemainingGas() {
            return 2.5;
        }
    }

    public class Furniture {
        public int pris { get; set; }
    }

    public class Chair : Furniture {
        public int ben { get; set; }
    }

    public class Computer : Furniture {
        public int cores { get; set; }
    }
}