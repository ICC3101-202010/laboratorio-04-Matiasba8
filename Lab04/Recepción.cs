using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class MRecepción:Maquina_Central
    {
        private int Memory_Recepcion;
        public MRecepción(string Funcion)
        {
            this.Funcion = Funcion;
        }

        public override void MANUALRESET()
        {
            throw new NotImplementedException();
        }

        public void Recepción()
        {
            Console.WriteLine("Recepción de la pieza realizada con exito!\n");
            Memory_Recepcion += 1;
        }
        public override void RESET()
        {
            if (Memory_Recepcion == 5)
            {
                //Reset
                Console.WriteLine("Reseteo de la maquina" + Funcion+"\n");
                //Se vacia la memoria
                Memory_Recepcion = 0;
            }
        }
    }
}
