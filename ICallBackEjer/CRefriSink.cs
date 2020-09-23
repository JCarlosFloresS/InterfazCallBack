using System;
using System.Collections.Generic;
using System.Text;

namespace ICallBackEjer
{
    class CRefriSink : IEventosRefri
    {
        //Aqui colocamos los handlers de los eventos definidos en la interfaz

        public void EReservasBajas(int pKilos)
        {
            //Aqui colocamos todo el codigo necesario para ejecuar cuando suceda el evento

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Reservas bajas de alimentos");
            Console.WriteLine("Quedan {0} kilos", pKilos);
        }
    }
}
