using Prototype.Example1;

Circulo circulo       = new Circulo { Id = 1};
Cuadrado cuadrado     = new Cuadrado { Id = 2 };
Rectangulo rectangulo = new Rectangulo { Id = 3 };
Triangulo triangulo   = new Triangulo { Id = 4 };


// Ahora a dibujar
circulo.Dibujar();
cuadrado.Dibujar();
rectangulo.Dibujar();
triangulo.Dibujar();

// Ahora a clonar los objetos
// (Circulo)circulo.Clonar();==> con esta intrucción "(Circulo)" se Castea el tipo de objeto en la variable
Circulo circuloClonado       =  (Circulo)circulo.Clonar();
Rectangulo rectanguloClonado = (Rectangulo)rectangulo.Clonar();
Cuadrado cuadradoClonado     = (Cuadrado)cuadrado.Clonar();
Triangulo trianguloClonado   = (Triangulo)triangulo.Clonar();

circuloClonado.Dibujar();
cuadradoClonado.Dibujar();
rectanguloClonado.Dibujar();
trianguloClonado.Dibujar();

cuadradoClonado.Id = 18;
cuadradoClonado.Dibujar();
circulo.Dibujar();