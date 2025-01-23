
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