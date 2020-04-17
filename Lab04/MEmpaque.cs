using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class MEmpaque:Maquina_Central
    {
        private int Memory_Empaque;
        public MEmpaque(string Funcion)
        {
            this.Funcion = Funcion;
        }

        public void Empaque()
        {
            Console.WriteLine("Recepción de la pieza realizada con exito!\n");
            Memory_Empaque += 1;
        }

        public override void MANUALRESET()
        {
            throw new NotImplementedException();
        }

        public override void RESET()
        {
            if (Memory_Empaque == 5)
            {
                //Reset
                Console.WriteLine("Reseteo de la maquina" + Funcion + "\n");
                //Se vacia la memoria
                Memory_Empaque = 0;
            }
        }
    }
}
