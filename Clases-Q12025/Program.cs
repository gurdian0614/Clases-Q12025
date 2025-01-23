
using Clases_Q12025;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

Ave ave = new Ave();
ave.Nombre = "Loro";
ave.Especie = "Amazona aestiva";
ave.Color = "Verde";
ave.Tamano = 30.5;
ave.Habitat = "Bosques Tropicales";
ave.Familia.Nombre = "Psittacidae";
ave.Familia.NumeroEspecie = 393;
ave.Familia.Caracteristicas = "Aves coloridas, a menudo inteligentes";
ave.Imprimir();

Ave ave2 = new Ave();
ave2.Nombre = "Flamenco";
ave2.Especie = "Phoenicopterus roseus";
ave2.Color = "Rosa";
ave2.Tamano = 120;
ave2.Habitat = "Lagunas Salinas";
ave2.Familia.Nombre = "Phoenicopteridae";
ave2.Familia.NumeroEspecie = 6;
ave2.Familia.Caracteristicas = "Aves zancudas con patas largas y cuellos largos.";
ave2.Imprimir();