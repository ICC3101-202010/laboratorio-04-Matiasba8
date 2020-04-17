using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class MEnsamblaje:Maquina_Central
    {
        private int Memory_Ensamblaje;
        public MEnsamblaje(string Funcion)
        {
            this.Funcion = Funcion;
        }

        public void Ensamblaje()
        {
            Console.WriteLine("Ensamblado de la pieza realizada con exito!\n");
            Memory_Ensamblaje += 1;
        }

        public override void MANUALRESET()
        {
            throw new NotImplementedException();
        }

        public override void RESET()
        {
            if (Memory_Ensamblaje == 5)
            {
                //Reset
                Console.WriteLine("Reseteo de la maquina" + Funcion + "\n");
                //Se vacia la memoria
                Memory_Ensamblaje = 0;
            }
        }
    }
}
