using System;
using System.Collections.Generic;
using System.Text;

namespace modelo.hardcore
{
    public class MedicosHardcode
    {
        private List<Medico> medicos;

        public MedicosHardcode()
        {
            this.medicos = new List<Medico>();
            cargarMedicos();
        }

        public List<Medico> medicosDisponiblesEspecialidad(Especialidad esp)
        {
            List<Medico> medicosDispo = new List<Medico>();

            foreach (Medico md in this.medicos)
            {
                if (md.propEsp == esp && md.propEstadLab == EstadoLaboral.trabajando)
                {
                    medicosDispo.Add(md);
                }
            }
            return medicosDispo;
        }
        private void cargarMedicos()
        {
            medicos.Add(new Medico(Especialidad.Medica_Clinica, modelo.EstadoLaboral.trabajando, 23587882, "Jiménez", "Franchesca"));
            medicos.Add(new Medico(Especialidad.Medica_Clinica, modelo.EstadoLaboral.trabajando, 33587881, "Juarez", "Miguel"));
            medicos.Add(new Medico(Especialidad.Cardiologia , modelo.EstadoLaboral.trabajando, 11898982, "Paez", "Mariana"));
            medicos.Add(new Medico(Especialidad.Traumaología, modelo.EstadoLaboral.trabajando, 20024881, "Rodriguez", "Roberto"));

            medicos.Add(new Medico(Especialidad.Electrocardiograma, modelo.EstadoLaboral.no_trabaja, 38752645, "Diaz", "Lara"));
            medicos.Add(new Medico(Especialidad.Reumatología, modelo.EstadoLaboral.no_trabaja, 33587555, "Manes", "Luana"));
            medicos.Add(new Medico(Especialidad.Cardiologia, modelo.EstadoLaboral.trabajando, 22773082, "Paez", "Mariana"));
            medicos.Add(new Medico(Especialidad.Rayos, modelo.EstadoLaboral.trabajando, 20024881, "Alonso", "Pedro"));

            medicos.Add(new Medico(Especialidad.Neumonología, modelo.EstadoLaboral.trabajando, 23555621, "Jiménez", "Franchesca"));
            medicos.Add(new Medico(Especialidad.Pediatria, modelo.EstadoLaboral.no_trabaja, 25430520, "Miranda", "Luisa"));
            medicos.Add(new Medico(Especialidad.Pediatria, modelo.EstadoLaboral.trabajando, 19330125, "Gutierrez", "Esteban"));
            medicos.Add(new Medico(Especialidad.Reumatología, modelo.EstadoLaboral.trabajando, 20025571, "Rodriguez", "Roberto"));

            medicos.Add(new Medico(Especialidad.Neumonología, modelo.EstadoLaboral.trabajando, 26787933, "Jiménez", "Franchesca"));
            medicos.Add(new Medico(Especialidad.Pediatria, modelo.EstadoLaboral.trabajando, 33587881, "Juarez", "Miguel"));
            medicos.Add(new Medico(Especialidad.Neumonología, modelo.EstadoLaboral.no_trabaja, 35120354, "Palermo", "Javier"));
            medicos.Add(new Medico(Especialidad.Rayos, modelo.EstadoLaboral.trabajando, 18602481, "Stigler", "Fausto"));
        }



    }
}
