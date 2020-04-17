using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {

            MRecepción recepción = new MRecepción("Recepcion");
            MAlmacenamiento almacenamiento = new MAlmacenamiento("Almacenado");
            MEnsamblaje ensamblaje = new MEnsamblaje("Ensamblado");
            MVerificación verificación = new MVerificación("Verificado");
            MEmpaque empaque = new MEmpaque("Empaquetado");

            int i = 6;
            while (i>=0)
            {
                if (i==6)
                {
                    recepción.ON();
                    almacenamiento.ON();
                    ensamblaje.ON();
                    verificación.ON();
                    empaque.ON();
                    Console.WriteLine("-----------------------------------\n");
                    
                }
                recepción.Recepción();
                ensamblaje.Ensamblaje();
                verificación.Verificación();
                empaque.Empaque();
                almacenamiento.Almacenamiento();
                Console.WriteLine("-----------------------------------\n");
                recepción.RESET();
                almacenamiento.RESET();
                ensamblaje.RESET();
                verificación.RESET();
                empaque.RESET();
               
                i--;
            }
            recepción.OFF();
            almacenamiento.OFF();
            ensamblaje.OFF();
            verificación.OFF();
            empaque.OFF();
            Console.WriteLine("-----------------------------------\n");


            Console.WriteLine("Fin del dia\n");
        }
        
    }
}
