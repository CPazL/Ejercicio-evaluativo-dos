
using System;

namespace modelo
{
   public class Consulta
    {
        
       private int idConsulta;
       private Medico medico;
       private Paciente paciente;
       private EstadoConsulta estado;
       private string resultado;
       private Especialidad especialidad;
       private static int siguienteidConsulta = 0;

        /// <summary>
        /// Constructor de la clase Consulta
        /// </summary>
        /// <param name="medico"></param>
        /// <param name="paciente"></param>
        /// <param name="resultado"></param>
        /// <param name="especialidad"></param>
        public Consulta( Medico medico, Paciente paciente, Especialidad especialidad)
        {
            this.idConsulta = siguienteidConsulta;
            this.medico = medico;
            this.paciente = paciente;
            this.estado = EstadoConsulta.En_espera;
            this.resultado = "";
            this.especialidad = especialidad;
            Consulta.siguienteidConsulta++;

        }
        public Consulta( Paciente paciente, Especialidad especialidad)
        {
            this.idConsulta = siguienteidConsulta;
            this.medico = null;
            this.paciente = paciente;
            this.estado = EstadoConsulta.En_espera;
            this.resultado = "";
            this.especialidad = especialidad;
            Consulta.siguienteidConsulta++;

        }
        /// <summary>
        /// Propiedades de los atributos de la clase Consulta.
        /// </summary>
        public Medico propMedico
        {
            get
            { return medico; }
            set
            { medico = value; }
        }
        public Paciente propPaciente
        {
            get
            { return paciente; }
            set
            { paciente = value; }
        }
        public string propResultado
        {
            get
            { return resultado; }
            set
            { resultado = value; }
        }
        public Especialidad propEspecialidad
        {
            get
            { return especialidad; }
            set
            { especialidad = value; }
        }
        public int getidConsulta()
        {
                return this.idConsulta;
        }
        /// <summary>
        /// Metodos de la clase:
        /// activarConsulta:
        /// </summary>
        
        public void activarConsulta()
        {
            this.estado = EstadoConsulta.Activa;
        }
        /// <summary>
        /// Finalizar consulta, termina con la consulta y guarde en la misma como se ha resuelto la misma.
        /// </summary>
        /// <param name="resultado"></param>
        public void finalizarConsulta(String resultado)
        {
            try{
               if (estado == EstadoConsulta.Activa)
                {
                    this.estado = EstadoConsulta.Finalizada;
                    this.resultado = resultado;
                }
                else
                {
                   Console.WriteLine("\n La consulta no está activada \n");
                }
            }
            catch
            {
                Console.WriteLine("\n La consulta no está activada \n");
            }
           
        }

     }

    public enum EstadoConsulta
    {
        En_espera, Activa, Finalizada
    }


}
