using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public abstract class Maquina_Central
    {
        private string funcion;

        protected string Funcion { get => funcion; set => funcion = value; }

        public void ON()
        {
            Console.WriteLine("Encendido de la maquina de " + Funcion + "\n");
        }
        public void OFF()
        {
            Console.WriteLine("Apagado de la maquina de " + Funcion + "\n");
        }
        public abstract void RESET();

        public abstract void MANUALRESET();

       
    }
}
