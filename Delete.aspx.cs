using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityManagement
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string universidad = DropDownList1.Text;
            string carne = TextBox1.Text;

            try
            {
                Universidad uSeleccionada = _Default.universidades.Find(u => u.Nombre.Equals(universidad));
                if (uSeleccionada.Alumnos.Find(a => a.Carne.Equals(carne)) != null)
                {
                    Response.Write("<script>alert('Alumno encontrado')</script>");
                }
                Button1.Enabled = true;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('No se ha podido encontrar al alumno')</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string universidad = DropDownList1.Text;
            string carne = TextBox1.Text;
            Universidad uSeleccionada = _Default.universidades.Find(u => u.Nombre.Equals(universidad));
            int index = uSeleccionada.Alumnos.FindIndex(a => a.Carne.Equals(carne));
            uSeleccionada.Alumnos.RemoveAt(index);
            _Default create = new _Default();
            create.GuardarDatos();
        }
    }
}