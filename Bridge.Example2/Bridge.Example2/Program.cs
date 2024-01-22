using Bridge.Example2;

Vehiculo vehiculoCombustion = new Automovil(new MotorCombustion());
Vehiculo vehiculoElectrico = new Bus(new MotorElectrico());

vehiculoCombustion.Conducir();
vehiculoElectrico.Conducir();