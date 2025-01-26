
using System.Drawing;
using Clase_1;
using static System.Runtime.InteropServices.JavaScript.JSType;

Ave ave = new Ave();
ave.Nombre = "Loro";
ave.Especie = "Amazona";
ave.Color = "Verde";
ave.Tamano = 30.5;
ave.Habitat = "Bosques tropicales";
ave.Familia.Nombre = "Psittacidae";
ave.Familia.NumeroEspecie = "393";
ave.Familia.Caracteristicas = "aves coloridas";
ave.Imprimir();

