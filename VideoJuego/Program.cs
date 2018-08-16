using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemigo EnemigoUnico = new Enemigo();

            EnemigoUnico.Nombre = "Hittler";
            EnemigoUnico.PosicionX = "15";
            EnemigoUnico.PosicionY = "8";
            EnemigoUnico.Puntos = "250";
            EnemigoUnico.Mover = "3";
            EnemigoUnico.Disparar = "180";
            EnemigoUnico.Explotar = "250";

            Console.WriteLine("Nombre: " + EnemigoUnico.Nombre);
            Console.WriteLine("Posicion en X: " + EnemigoUnico.PosicionX);
            Console.WriteLine("Posicion en Y: " + EnemigoUnico.PosicionY);
            Console.WriteLine("Puntos acumulados: " + EnemigoUnico.Puntos);
            Console.WriteLine("Mover a la posicion: " + EnemigoUnico.Mover);
            Console.WriteLine("Telefono Celular: " + EnemigoUnico.Disparar);
            Console.WriteLine("Exploto: " + EnemigoUnico.Explotar);
            Console.ReadLine();

        }
    }
}
