using System;
using System.Collections.Generic;
using System.Text;

namespace modelo.hardcore
{
    public class PacientesHardCode
    {
        private Queue<Paciente> pacientes;



        public PacientesHardCode()
        {
            this.pacientes = new Queue<Paciente>();
            cargarPacientes();
        }


        private void cargarPacientes()
        {
          
            pacientes.Enqueue(new Paciente(23587880, "Juarez", "Franco", 48, ObraSocial.CoberturaBasica));
            pacientes.Enqueue(new Paciente(11898982, "Toro", "Marthyna", 75, ObraSocial.CoberturaBasica));
            pacientes.Enqueue(new Paciente(23587880, "Vega", "Michel", 50, ObraSocial.CoberturaCompleta));
            pacientes.Enqueue(new Paciente(45251245, "Peña", "Hellen", 75, ObraSocial.NoTiene));
            pacientes.Enqueue(new Paciente(23587880, "Pino", "Dante", 48, ObraSocial.CoberturaBasica));
            pacientes.Enqueue(new Paciente(11898982, "Vidal", "Siomara", 75, ObraSocial.CoberturaBasica));
            pacientes.Enqueue(new Paciente(23587880, "Bravo", "Jair" , 50, ObraSocial.CoberturaCompleta));
            pacientes.Enqueue(new Paciente(45251245, "Figueroa", "León", 75, ObraSocial.NoTiene));
            pacientes.Enqueue(new Paciente(23587880, "Torres", "Gerard", 50, ObraSocial.CoberturaCompleta));
            pacientes.Enqueue(new Paciente(43251245, "Maldonado", "Viktor", 75, ObraSocial.NoTiene));
            pacientes.Enqueue(new Paciente(54255245, "Flores", "Richard", 12, ObraSocial.NoTiene));
            pacientes.Enqueue(new Paciente(22321245, "Vega", "Noemí", 48, ObraSocial.NoTiene));
            pacientes.Enqueue(new Paciente(12251245, "Rodríguez", "Teresa", 75, ObraSocial.NoTiene)); 
            pacientes.Enqueue(new Paciente(39597222, "Alarcón", "Yamilet", 63, ObraSocial.NoTiene));
            pacientes.Enqueue(new Paciente(16251245, "Rodríguez", "Isaias", 56, ObraSocial.NoTiene));

        }
        ///<Sumary>
        ///SobrecargadeConversores
        ///</Sumary>
        
        public static explicit operator Queue<Paciente>(PacientesHardCode p)
        {
            return p.pacientes;
        }
    }
}
