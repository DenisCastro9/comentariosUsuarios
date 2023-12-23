using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace finalTP2
{
    public partial class alta_comentario : Form
    {
        public alta_comentario()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;

        private void alta_comentario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'finalTP2DataSet1.redSocial' Puede moverla o quitarla según sea necesario.
            this.redSocialTableAdapter.Fill(this.finalTP2DataSet1.redSocial);
            // TODO: esta línea de código carga datos en la tabla 'finalTP2DataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.finalTP2DataSet.usuarios);

            conexion = new SqlConnection("Data Source = DESKTOP-TDSHAI5\\SQLEXPRESS; Initial Catalog = finalTP2; Integrated Security = true");
            adaptador = new SqlDataAdapter();

            SqlCommand altac = new SqlCommand("INSERT INTO comentarios VALUES (@fecha_hora, @descripcion, @id_usuario, @id_redSocial)", conexion);
            adaptador.InsertCommand = altac;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fecha_hora", SqlDbType.Date));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@id_usuario", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@id_redSocial", SqlDbType.Int));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adaptador.InsertCommand.Parameters["@fecha_hora"].Value = fechaC_dtp.Value;
            adaptador.InsertCommand.Parameters["@descripcion"].Value = comentario_txt.Text;
            adaptador.InsertCommand.Parameters["@id_usuario"].Value = nombre_cmb.SelectedValue;
            adaptador.InsertCommand.Parameters["@id_redSocial"].Value = redSocial_cmb.SelectedValue;
            try
            {
                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("El comentario se subio correctamente");
                
            }
            catch(SqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public void limpiar()
        {
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                    comentario_txt.Focus();
                }
            }
        }
    }
}
