
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

Ave ave2 = new Ave();
ave2.Nombre = "Flamenco";
ave2.Especie = "roseus";
ave2.Color = "rosa";
ave2.Tamano = 120;
ave2.Habitat = "lagunas salinas";
ave2.Familia.Nombre = "copteridae";
ave2.Familia.NumeroEspecie = "6";
ave2.Familia.Caracteristicas = "aves zancuadas con patas y coellos largos";
ave2.Imprimir();
