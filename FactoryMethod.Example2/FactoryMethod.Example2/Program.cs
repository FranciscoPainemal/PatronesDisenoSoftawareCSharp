using FactoryMethod.Example2;
using FactoryMethod.Example2.Fabricas;
Console.WriteLine("Hello, World!... vienbenido a las notificaciones");

while (true) 
{
    Console.WriteLine($"\n Por favor elija el tipo de NOTIFICACIÓN que desea enviar:\n (1) Correo\n (2) Push\n (3) Sms\n  Debe escribir solo un número");
    int notificacionElejida = Convert.ToInt32(Console.ReadLine());
    FabricaNotificacion fabricaNotificacion = null;

    switch (notificacionElejida)
    {
        case 1:
            fabricaNotificacion = new FabricaNotificacionCorreo(); 
            break;
        case 2:
            fabricaNotificacion = new FabricaNotificacionPush();
            break;

        case 3:
            fabricaNotificacion = new FabricaNotificacionSMS();
            break;
        default:
            break;
    }

    INotificacion notificacionHecha = fabricaNotificacion.CrearNotificacion();
    Console.WriteLine($"Por favor ingrese mensaje de la notificación tipo {notificacionHecha.GetType().Name}");
    string mensaje = Console.ReadLine();
    notificacionHecha.Enviar(mensaje);
}

Console.WriteLine($"Gracias por usaar el sistema");
Console.ReadKey();

////
/// resumen de como se debe hacer
/// 1) crear primero la clase Interface en raiz: INotificacion
/// 2) crear Carpetas en raiz: Fabricas y Productos
/// 3) crear clase en carpeta Fabricas: FabricaNotificacion
/// 4) crear Clases en carpeta Productos: Correo,Push y Sms 
/// 5) crear Clases en carpeta Fabricas: FabricaNotificacionCorreo,FabricaNotificacionPush y FabricaNotificacionSms 
/// 6) crearlas en la clase Program en raiz con todo la lógica