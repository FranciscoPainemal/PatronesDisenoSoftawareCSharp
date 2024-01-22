using Bridege.Example1;

IFormato formato_mp3           = new MP3();
ReproductorMusical reproductor = new ReproductorEscritorio(formato_mp3);
reproductor.ReproducirArchivo("cancion animal.mp3");

IFormato formato_wam = new WAV();
reproductor          = new ReproductorCelular(formato_wam);
reproductor.ReproducirArchivo("video uno.wav");