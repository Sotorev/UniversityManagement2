using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagement
{
    public class Persona
    {
        public DateTime birthDay;
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad {
            get {
                int edad = DateTime.Now.Year - birthDay.Year;
                if (DateTime.Now.Month > birthDay.Month)
                    return edad;
                else
                    return edad - 1;
            }
        }

    }
}