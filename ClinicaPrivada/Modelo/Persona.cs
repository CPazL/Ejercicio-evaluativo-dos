using System;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
    public abstract class Persona
    {
        private int dni;
        private string nombre;
        private string apellido;
        private int edad;

        /// <summary>
        /// Sobrecarga de constructor de la clase Persona
        /// </summary>
        protected Persona()
        {
        }

        protected Persona(int dni, string nombre, string apellido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = 0;
        }

        protected Persona(int dni, string nombre, string apellido, int edad) : this(dni, nombre, apellido)
        {
            this.edad = edad;
        }
        /// <summary>
        /// Propiedades de los atributos.
        /// </summary>
        public int propDni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }
        public string propNombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string propApellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public int propEdad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        /// <summary>
        /// Con la siguiente sobrecarga de operadores se puede averiguar si se ingreso dos veces a una persona
        /// o si hay dos personas con el mismo DNI
        /// </summary>

        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1.dni == p2.dni;
        }
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
    }
}

