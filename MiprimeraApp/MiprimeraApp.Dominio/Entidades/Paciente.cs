using System;
using System.Collections.Generic;

namespace MiprimeraApp.Dominio
{
    public class Paciente : Persona
    {
        public string Direccion {get; set;}
        public string ciudad {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public Medico Medico  {get; set;}
        

    }
}