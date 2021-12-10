

using modelo;
using vista;

namespace controlador
{
   public class Principal
    {

        public static void main(string[] args)
        {
            Modelo m = new Modelo();

            Form1 v = new Form1();

            Controlador c = new Controlador(m, v);

            c.iniciar();
        }
    }
}
