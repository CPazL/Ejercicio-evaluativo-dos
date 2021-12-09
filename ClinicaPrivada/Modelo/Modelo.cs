using modelo.hardcore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
    public class Modelo
    { 
        private PacientesHardCode phardcode;

        public PacientesHardCode Phardcode { get => phardcode; set => phardcode = value; }

        public Queue<Consulta> pacienteXEspecialidad(Especialidad esp)
        {
            Queue<Consulta> consultasXEspecialidad = new Queue<Consulta>();
            Consulta con;
            try
            {

                foreach (Paciente p in ((Queue<Paciente>)Phardcode) )
                {

                    con = new Consulta(p, esp);
                    consultasXEspecialidad.Enqueue(con);
                }
                return consultasXEspecialidad;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

            return consultasXEspecialidad;

        }

        public Queue<Consulta> asignarMedicoAConsulta(List<Medico> medDispo , Queue<Consulta> consEsp)
        {
            Queue<Consulta> consultasAsignadas = new Queue<Consulta>();
            Consulta auxiliar;
            while (consEsp != null)
            {
                foreach (Medico md in medDispo)
                {
                    if (consEsp.Count>0) { 

                        auxiliar = consEsp.Peek();
                        auxiliar.propMedico = md;
                        consultasAsignadas.Enqueue(auxiliar);
                        consEsp.Dequeue();
                    }
                    else
                    {
                        return consultasAsignadas;
                    }
                }
            }
            return consultasAsignadas;

        }

       


       


        



    }
}
