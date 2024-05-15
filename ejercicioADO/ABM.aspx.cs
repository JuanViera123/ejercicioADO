using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicioADO
{
    public partial class ABM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-D7GKDQET;Initial Catalog=biblioteca;Integrated Security=true";
            
        }

        protected void ButtonAutor_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-D7GKDQET;Initial Catalog=biblioteca;Integrated Security=true";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = "insert into Autor(nombre, apellido, fecha_nac, nacionalidad) values(@param1, @param2, @param3, @param4)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@param1", txt_nombre.Text);
                cmd.Parameters.AddWithValue("@param2", txt_apellido.Text);
                cmd.Parameters.AddWithValue("@param3", txt_nacimiento.Text);
                cmd.Parameters.AddWithValue("@param4", txt_nacionalidad.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                txt_nombre.Text = null;
                txt_apellido.Text = null;
                txt_nacimiento.Text = null;
                txt_nacionalidad.Text = null;
            }
        }

        protected void ButtonBusquedaAutor_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-D7GKDQET;Initial Catalog=biblioteca;Integrated Security=true";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "select * from Autor Where Autor.nombre like " + "'" + txt_busquedaAutor.Text + "%" + "'" + " or Autor.apellido like " + "'" + txt_busquedaAutor.Text + "%" + "'";

                SqlCommand cmd = new SqlCommand(query, conn);

                           
                GridAutores.DataSource = cmd.ExecuteReader();
                GridAutores.DataBind();
               
              conn.Close();

               
            }
        }

      

        protected void GridAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-D7GKDQET;Initial Catalog=biblioteca;Integrated Security=true";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "delete from Autor where id=" + GridAutores.SelectedRow.Cells[1].Text;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                conn.Close();


            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {

                lbl_nombre.Visible = true;
                lbl_apellido.Visible = true;
                lbl_nacionalidad.Visible = true;
                fecnac.Visible = true;
                txt_nombre.Visible = true;
                txt_apellido.Visible = true;
                txt_nacimiento.Visible = true;
                txt_nacionalidad.Visible = true;
                txt_busquedaAutor.Visible = true;
                ButtonBusquedaAutor.Visible = true;
                GridAutores.Visible = true;
        
              
            
        }

        protected void mostrar_ABLibro_Click(object sender, EventArgs e)
        {
            lbl_titulo.Visible = true;
            lbl_autor.Visible = true;
            lbl_descripcion.Visible = true;
            lbl_year.Visible = true;
            txt_titulo.Visible=true;
            list_autores.Visible = true;
            txt_descripcion.Visible=true;
            txt_year.Visible=true;
            btn_agregarLibro.Visible = true;
            Label1.Visible = true;
            txt_busquedaLibro.Visible=true;
            GridLibros.Visible = true;

            string connectionString = "Data Source=LAPTOP-D7GKDQET;Initial Catalog=biblioteca;Integrated Security=true";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "select * from Autor";

                SqlCommand cmd = new SqlCommand(query, conn);


                list_autores.DataSource = cmd.ExecuteReader();
                list_autores.DataBind();

                conn.Close();


            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-D7GKDQET;Initial Catalog=biblioteca;Integrated Security=true";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = "insert into libro(titulo, id_autor, descripcion, año) values(@param1, @param2, @param3, @param4)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@param1", txt_titulo.Text);
                cmd.Parameters.AddWithValue("@param2", list_autores.SelectedRow.Cells[1].Text);
                cmd.Parameters.AddWithValue("@param3", txt_descripcion.Text);
                cmd.Parameters.AddWithValue("@param4", txt_year.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                txt_titulo = null;
           
                txt_descripcion.Text = null;
                txt_year.Text = null;
            }
        }

        protected void GridLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-D7GKDQET;Initial Catalog=biblioteca;Integrated Security=true";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "delete from libro where id=" + GridLibros.SelectedRow.Cells[1].Text;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                conn.Close();


            }
        }

        protected void txt_busquedaLibro_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-D7GKDQET;Initial Catalog=biblioteca;Integrated Security=true";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "select * from libro Where libro.titulo like " + "'" + txt_busquedaLibro.Text + "%" +  "'";

                SqlCommand cmd = new SqlCommand(query, conn);


                GridLibros.DataSource = cmd.ExecuteReader();
                GridLibros.DataBind();
                
                conn.Close();


            }
        }
    }
    }
