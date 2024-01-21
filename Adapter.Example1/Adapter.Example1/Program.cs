using Adapter.Example1;

SistemaDeComunicacion sistemaDeComunicacion = new SistemaDeComunicacion();

HablanteIngles hablanteIngles = new HablanteIngles();
sistemaDeComunicacion.ComenzarConversacion(hablanteIngles, "Hi MDF, How are you?", "I´m Fine SANAPAPICH");


HablanteEspanol hablanteEspanol = new HablanteEspanol();
Traductor traductor = new Traductor(hablanteEspanol);
sistemaDeComunicacion.ComenzarConversacion(traductor, "Hola gringo cabron", "Hola culero");