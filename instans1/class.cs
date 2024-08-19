namespace classes {
    public class Bog {

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

