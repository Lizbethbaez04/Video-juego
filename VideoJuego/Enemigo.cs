using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoJuego
{
    class Enemigo
    {
        //Auto properties
        public string Nombre { get; set; }
        public string PosicionX { get; set; }
        public string PosicionY { get; set; }
        public string Puntos { get; set; }
        public string Mover { get; set; }
        public string Disparar { get; set; }

        //Properties
        private string _explotar;
        public string Explotar
        {
            get
            {
                return _explotar;
            }
            set
            {
                if (value.Length == 250)
                //length sirve para obtener los numeros
                {
                    Console.WriteLine("Haz derrotado al villano");
                }
                else if (value.Length == 215)
                //Poner la lada
                {
                    Console.WriteLine("Bonus de 14 puntos por tu rebeldía");
                }
                else
                {
                    Console.WriteLine("Sigue intentando con mas fuerza");
                }
            }
        }
    }








}
