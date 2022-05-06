using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityManagement
{
    public partial class _Default : Page
    {
        public static List<PersonalAdministrativo> personal = new List<PersonalAdministrativo>();
        public static List<PersonalAdministrativo> personalTemp = new List<PersonalAdministrativo>();
        public static List<Alumno> alumnos = new List<Alumno>();
        public static List<Alumno> alumnosTemp;
        public static List<Universidad> universidades = new List<Universidad>();
        public static List<Nota> notasTemp = new List<Nota>();
        protected void Page_Load(object sender, EventArgs e)
        {
            LeerDatos();
            ActualizarPersonal();
        }
        public void LeerDatos()
        {
            string archivo = Server.MapPath("Universidades.json");

            try
            {
                StreamReader jsonStream = File.OpenText(archivo);
                string json = jsonStream.ReadToEnd();
                jsonStream.Close();
                if (json.Length > 0)
                {
                    universidades = JsonConvert.DeserializeObject<List<Universidad>>(json);
                }
            }
            catch(Exception e)
            {

            }
            
            
        }
        public void GuardarDatos()
        {
            string json = JsonConvert.SerializeObject(universidades);
            string archivo = Server.MapPath("Universidades.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        void LimpiarCajas()
        {
            TextBox1.Text = null;
            TextBox2.Text = null;
            TextBox3.Text = null;
        }
        
        void ActualizarPersonal()
        {

            string universidadSeleccionada = DropDownList1.Text;
            try
            {
                List<PersonalAdministrativo> source = universidades.Find(u =>
                            u.Nombre.Equals(universidadSeleccionada)).Personal;
                if(source != null)
                    personal = source;
                GridView2.DataSource = source;
                GridView2.DataBind();

            }
            catch (Exception ex)
            {
                personal = new List<PersonalAdministrativo>();
                GridView2.DataSource = null;
                GridView2.DataBind();
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            PersonalAdministrativo p = new PersonalAdministrativo()
            {
                NoIggs = TextBox1.Text,
                Nombre = TextBox2.Text,
                Apellido = TextBox3.Text
            };
            personal.Add(p);
            personalTemp = personal;
            GridView2.DataSource = personal;
            GridView2.DataBind();
            notasTemp.Clear();
            LimpiarCajas();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if(universidades.Find(uni => uni.Nombre.Equals(DropDownList1.Text)) ==
                null)
            {
                Universidad u = new Universidad()
                {
                    Personal = personalTemp,
                    Alumnos = alumnosTemp,
                    Nombre = DropDownList1.Text
                };
                universidades.Add(u);
            }
            else
            {
                universidades.Find(uni => uni.Nombre.Equals(DropDownList1.Text)).
                    Personal = personalTemp;
            }
            GuardarDatos();
            alumnos.Clear();
            GridView2.DataSource = personalTemp;
            GridView2.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}