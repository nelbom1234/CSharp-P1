namespace Classes {
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
}