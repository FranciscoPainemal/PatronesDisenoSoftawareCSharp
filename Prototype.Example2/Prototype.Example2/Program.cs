using Prototype.Example2;
using System.Drawing;

Momia momia     = new Momia { Identificador = 1 ,Nombramiento = "MOMIAES", Vendaje = 432};
Vampiro vampiro = new Vampiro { Identificador = 2, Nombramiento = "DRACULA", SedDeSangre = 9999};
Zombie zombie   = new Zombie { Identificador = 3, Nombramiento= "zOMBIENWEONES", Salud = 1000 };


// Ahora a dibujar
momia.Atacar();
vampiro.Atacar();
zombie.Atacar();

// Ahora a clonar los objetos
//Vampiro(Vampiro)Momia.Clonar();==> con esta intrucción "(Vampiro)" se Castea el tipo de objeto en la variable
Vampiro vampiroClonado = (Vampiro)vampiro.Clonar();

vampiroClonado.Identificador = 54;
vampiroClonado.Nombramiento = "wladimir";
vampiroClonado.SedDeSangre = 700;
vampiroClonado.Atacar();
