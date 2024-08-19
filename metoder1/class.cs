namespace classes {
    public class Bog {
        public void PrintInfo() {
            Console.WriteLine("Jeg er en bog");
        }

        public bool HarRåd(int pris, int penge) {
            return pris <= penge;
        }
    }
}