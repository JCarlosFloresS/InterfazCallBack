using System;

namespace ICallBackEjer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos un refri
            CRefri Refri = new CRefri(50, -20);
            Random rnd = new Random();

            //Creamos el sink
            CRefriSink sink1 = new CRefriSink();

            //Adicionamos el sink al refri
            Refri.AgregarSink(sink1);

            //El refri hace su trabajo
            while (Refri.Kilos > 0)
            {
                //El refri trabaja y le quitamos kilos al azar
                Refri.Trabajar(rnd.Next(1, 5));
            }
        }
    }
}
