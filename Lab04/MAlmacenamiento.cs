using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class MAlmacenamiento:Maquina_Central
    {
        private int Memory_Almacenamiento;
        public MAlmacenamiento(string Funcion)
        {
            this.Funcion = Funcion;
        }

        public void Almacenamiento()
        {
            Console.WriteLine("Recepción de la pieza realizada con exito!\n");
            Memory_Almacenamiento += 1;
        }

        public override void MANUALRESET()
        {
            throw new NotImplementedException();
        }

        public override void RESET()
        {
            if (Memory_Almacenamiento == 5)
            {
                //Reset
                Console.WriteLine("Reseteo de la maquina" + Funcion + "\n");
                //Se vacia la memoria
                Memory_Almacenamiento = 0;
            }
        }
    }
}
