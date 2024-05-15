using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicioADO
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void BBuscar_Click(object sender, EventArgs e)
        {  
            string connectionString = "Data Source=LAPTOP-D7GKDQET;Initial Catalog=biblioteca;Integrated Security=true";
            string query = "Select * from libro";

            switch (this.DropDownList1.SelectedItem.Text)
            {
                case "Autor":
                    query = "select libro.titulo, libro.descripcion, Autor.nombre, Autor.apellido from libro inner join Autor on libro.id_autor = Autor.id and Autor.nombre = " + "'" + this.busqueda.Text + "'";
                    break;
                case "Titulo":
                    query = "select libro.titulo, libro.descripcion, Autor.nombre, Autor.apellido from libro inner join Autor on libro.id_autor = Autor.id where libro.titulo = " + "'" + this.busqueda.Text + "'";
                    break;
                case "Año":
                    query = "select libro.titulo, libro.descripcion, Autor.nombre, Autor.apellido from libro inner join Autor on libro.id_autor = Autor.id and libro.año = " + this.busqueda.Text;
                    break;

            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);



                this.GridView2.DataSource = cmd.ExecuteReader();
                this.GridView2.DataBind();

                conn.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-D7GKDQET;Initial Catalog=biblioteca;Integrated Security=true";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "Select * from Autor where Autor.nombre like " + "'" + this.TextBox1.Text + "%" + "'" + "or Autor.apellido like " + "'" + this.TextBox1.Text + "%" + "'";
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);



                this.GridView2.DataSource = cmd.ExecuteReader();
                this.GridView2.DataBind();
            }
        }
    }
}
