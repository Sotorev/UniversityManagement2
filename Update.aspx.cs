using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityManagement
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string universidad = DropDownList1.Text;
            string nombre = TextBox1.Text;

            try
            {
                Universidad uSeleccionada = _Default.universidades.Find(u => u.Nombre.Equals(universidad));
                if(uSeleccionada.Alumnos.Find(a => a.Nombre.Equals(nombre)).Nombre != null)
                {
                    Response.Write("<script>alert('Alumno encontrado')</script>");
                }
                Button1.Enabled = true;
                TextBox2.Enabled = true;
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('No se ha podido encontrar al alumno')</script>");
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre = TextBox1.Text;
            string universidad = DropDownList1.Text;
            string nuevoNombre = TextBox2.Text;
            Universidad uSeleccionada = _Default.universidades.Find(u => u.Nombre.Equals(universidad));
            uSeleccionada.Alumnos.Find(a => a.Nombre.Equals(nombre)).Nombre = nuevoNombre;
            _Default create = new _Default();
            create.GuardarDatos();
        }
    }
}