using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloABM
{
    public class Persona
    {
        public string apellido { get; set; } 
        public string nombre { get; set; }
        public string tipoDocumento { get; set; }
        public int documento { get; set; }
        public string estadoCivil { get; set; }
        public string sexo { get; set; }
        public bool fallecido { get; set; }

        public Persona() 
        {
            apellido = string.Empty;
            nombre = string.Empty;
            tipoDocumento = string.Empty;
            documento = 0;
            sexo = string.Empty;
        }

        public Persona(string apellido, string nombre, string tipoDocumento, int documento,string estadoCivil, string sexo, bool fallecido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.tipoDocumento = tipoDocumento;
            this.documento = documento;
            this.estadoCivil = estadoCivil;
            this.sexo = sexo;
            this.fallecido = fallecido;
        }

        public override string ToString()
        {
            return $"{nombre}, {apellido}";
        }
        /*public string MostrarPersonaSeleccionada(Persona personaSeleccionada)
        {
            return $"Nombre: {personaSeleccionada.nombre}\n" +
                $"Apellido: {personaSeleccionada.apellido}\n" +
                $"Tipo de documento: {personaSeleccionada.tipoDocumento}\n" +
                $"Nro Documento: {personaSeleccionada.documento}\n" +
                $"Estado Civil: {personaSeleccionada.estadoCivil}\n" +
                $"Sexo: {personaSeleccionada.sexo} \n" +
                $"Fallecido: {personaSeleccionada.fallecido}";
        }*/
    }
}
