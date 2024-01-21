using Singleton.Example2;

MySingleton instance1 = MySingleton.GetInstance();
MySingleton instance2 = MySingleton.GetInstance();
MySingleton instance3 = MySingleton.GetInstance();

Console.WriteLine($"Instancia 1: {instance1.Id}; INstancia 2: {instance2.Id}; Instancia 3: {instance3.Id}");

/// este código se hace para controlar el acceso a una instancia y para asegurarnos 
/// de que siempre la instancia que se deviuelva sea la misma