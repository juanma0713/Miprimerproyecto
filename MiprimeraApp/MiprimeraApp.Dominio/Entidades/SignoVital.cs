using System;

namespace MiprimeraApp.Dominio.Entidades
{
    public class SignoVital
    {
        public int Id {get; set;}
        
        public DateTime FechaHora {get; set;}
        public float Valor {get; set;}
        public Tiposigno Signo {get; set;}
        public Paciente Paciente {get; set;}

    
    }
}