using System;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
    /// <summary>
    /// Medico deriva de la clase persona
    /// </summary>
    public class Medico: Persona
    {

        private Especialidad especialidad;
        private EstadoLaboral estadolab;
         /// <summary>
         /// Sobrecarga del construtor de Medico
         /// </summary>
        public Medico()
        {
        }

        public Medico(Especialidad espe, EstadoLaboral estadolab, int dni, string nombre, string apellido) : base(dni, nombre, apellido)
        {
            this.especialidad = espe;
            this.estadolab = estadolab;
        }

        public Medico(Especialidad espe, EstadoLaboral estadolab, int dni, string nombre, string apellido, int edad) : base(dni, nombre, apellido, edad)
        {
            this.especialidad = espe;
            this.estadolab = estadolab;
        }

        /// <summary>
        /// Propiedades de los atributos especialidad y estadlolab
        /// </summary>
        public Especialidad propEsp
        {
            get
            {
                return especialidad;
            }
            set
            {
                especialidad = value;
            }
        }
        public EstadoLaboral propEstadLab
        {
            get
            {
                return estadolab;
            }
            set
            {
                estadolab = value;
            }
        }
    }
    /// <summary>
    /// Estado laboral actual del medico
    /// </summary>
    public enum EstadoLaboral
    {
        trabajando, no_trabaja
    }

}
