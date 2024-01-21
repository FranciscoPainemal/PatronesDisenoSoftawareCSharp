using FactoryMethod.Example1;
using FactoryMethod.Example1.Fabricas;

Console.WriteLine("Hello, World!... vienbenido a la fabrica de vehículos");

// es una clase abstracta que no puede ser instanceada
FabricaVehiculo fabricaVehiculo = null;

while (true)
{
    Console.WriteLine($"\n Por favor elija el tipo Vehículo que desea Fabricar:\n (1) Automovil\n (2) Motocicleta\n (3) Bicicleta\n (4) Salir\n\n\n Debe escribir solo un número");
    
    int vehiculoElejido = Convert.ToInt32( Console.ReadLine() );

    switch (vehiculoElejido)
    {
        case 1:
            fabricaVehiculo = new FabricaAutomovil();
            break;

        case 2:
            fabricaVehiculo = new FabricaMotocicleta();
            break;

        case 3:
            fabricaVehiculo = new FabricaBicicleta();
            break;

        case 4:
            break;

        default:
            break;
    }
    // se utilza la clse abstracta fabricaVehiculo, que no puede ser instanciada
    // sin una instancia concreta(FabricaAutomovil, FabricaMotocicleta, FabricaBicicleta, etc)
    IVehiculo vehiculoHecho = fabricaVehiculo.OrdenarVehiculo();

    // GetType().Name devuele el tipo de vehículo elejido
    Console.WriteLine($"\nUd ha creado el siguiente tipo de vehículo: {vehiculoHecho.GetType().Name}.\n");
}

Console.WriteLine($"GRacias por usaar el sistema");
Console.ReadKey();