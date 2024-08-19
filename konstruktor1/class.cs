namespace classes {
    public class Bog {

        public Bog(int _pris, string _titel) {
            pris = _pris;
            titel = _titel;
        }

        public Bog(int _pris) {
            pris = _pris;
        }

        public int pris { get; set; }
        public string titel { get; set; }

        public void PrintInfo() {
            Console.WriteLine("Jeg er en bog");
        }

        public bool HarRåd(int penge) {
            return pris <= penge;
        }
    }
}

