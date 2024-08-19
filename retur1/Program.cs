using Classes;

var vroom = new Bil();

void et() {
    vroom.MotorTændt();
    vroom.MotorSlukket();
}

void to() {
    double variabel = 2.5;
    vroom.FillGas(variabel, false);
}

void tre() {
    vroom.FillGas(2.5, false);
}

void fire() {
    Console.WriteLine(vroom.RemainingGas());
}

fire();