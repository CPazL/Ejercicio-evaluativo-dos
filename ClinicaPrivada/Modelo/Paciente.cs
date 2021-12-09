using System;

namespace modelo
{
    /// <summary>
    /// Paciente es una clase que deriva de Persona 
    /// </summary>
    public class Paciente: Persona
    {
        private ObraSocial obraSoc;

        /// <summary>
        /// Sobre carga de constructor de la clase Paciente
        /// </summary>

        /// <param name="obraSoc"> Obra Social</param>
        public Paciente(int dni, string nombre, string apellido, int edad, ObraSocial obraSoc) : base(dni, nombre, apellido, edad)
        {
            this.obraSoc = obraSoc;
        }

        public Paciente(int dni, string nombre, string apellido, ObraSocial obraSoc) : base(dni, nombre, apellido)
        {
            this.obraSoc = obraSoc;
        }
        /// <summary>
        /// Proppiedades del atributo obraSoc
        /// </summary>
        public ObraSocial propObrasocial
        {
            get
            {
                return obraSoc;
            }
            set
            {
                obraSoc = value;
            }
        }
    }


    /// <summary>
    /// Enumeración del tipo de servicio que tiene cubierto el usuario dependiendo de si tiene o no Obra Social
    /// </summary>
    public enum ObraSocial
    {
        NoTiene, CoberturaBasica, CoberturaCompleta
    }


}
