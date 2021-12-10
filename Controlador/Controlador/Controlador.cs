using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using modelo;
using vista;

namespace controlador
{
    public class Controlador
    {
      private Modelo m;
      private Form1 v;
      private PacientesForm pf;
      private medicosForm mf;

        public Controlador()
        {
        }

        public Controlador(Modelo m, Form1 v)
        {
            this.m = m;
            this.v = v;
        }
        public void iniciar()
        {
                try
                {

            }
                catch (Exception ex)
                {
                         MessageBox.Show(ex.Message);

            }
            
        }
    }
}
