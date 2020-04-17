using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class MVerificación : Maquina_Central
    {
        private int Memory_Verificacion;
        public MVerificación(string Funcion)
        {
            this.Funcion = Funcion;
        }

        public void Verificación()
        {
            Console.WriteLine("Verificación de la pieza realizada con exito!\n");
            Memory_Verificacion += 1;
        }
        public override void RESET()
        {
            if (Memory_Verificacion == 5)
            {
                //Reset
                Console.WriteLine("Reseteo de la maquina" + Funcion + "\n");
                //Se vacia la memoria
                Memory_Verificacion = 0;

            }
        }

        public override void MANUALRESET()
        {
            throw new NotImplementedException();
        }
    }

}