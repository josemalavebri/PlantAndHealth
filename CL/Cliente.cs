using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.CL
{
    public class Cliente:Persona
    {
        public int Numero {  get; set; }
        public string Id  { get; set;}        
        public int Edad {  get; set; }
        public string EstadoCivil {  get; set; }
        public string Residencia {  get; set; }
        public string Origen {  get; set; }
    }
}
