using Adapter.Example2;

BaseDatosHeredada baseDatosHeredada = new BaseDatosHeredada();
AdaptadorBaseDatos adaptador        = new AdaptadorBaseDatos(baseDatosHeredada);
NuevoSistema nuevoSistema           = new NuevoSistema(adaptador);

nuevoSistema.GuardarDatos("Importar Data");
nuevoSistema.LeerDatos();

