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
            _Default create = new _Default();
            create.LeerDatos();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string universidad = DropDownList1.Text;
            string id = TextBox1.Text;

            try
            {
                Universidad uSeleccionada = _Default.universidades.Find(u => u.Nombre.Equals(universidad));
                if (uSeleccionada.Profesores.Find(p => p.Id.Equals(id)) != null)
                {
                    Response.Write("<script>alert('Profesor encontrado')</script>");
                    Button1.Enabled = true;
                }
                else
                    Response.Write("<script>alert('No se ha podido encontrar al profesor')</script>");

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('No se ha podido encontrar al profesor')</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string universidad = DropDownList1.Text;
            string id = TextBox1.Text;
            Universidad uSeleccionada = _Default.universidades.Find(u => u.Nombre.Equals(universidad));
            int index = uSeleccionada.Profesores.FindIndex(p => p.Id.Equals(id));
            uSeleccionada.Profesores.RemoveAt(index);
            _Default create = new _Default();
            create.GuardarDatos();
        }
    }
}