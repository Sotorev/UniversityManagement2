using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagement
{
    public class PersonalAdministrativo : Persona
    {
        public string NoIggs{ get; set; }
        public DateTime InicioDeLabores { get; set; }
        public DateTime FinDeLabores { get; set; }
        public string Profesion { get; set; }
    }
}