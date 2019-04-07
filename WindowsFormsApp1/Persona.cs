using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string GustosMusicales { get; set; }
        public string ColorPreferido { get; set; }

        public Persona(string nombre, string apellido, string fechaNacimiento, string sexo, string gustosMusicales, string colorPreferido)
        {

            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            GustosMusicales = gustosMusicales;
            ColorPreferido = colorPreferido;
        }

    }

}
