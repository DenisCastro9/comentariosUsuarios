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
    public partial class alta_usuario : Form
    {
        public alta_usuario()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;

        private void alta_usuario_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source = DESKTOP-TDSHAI5\\SQLEXPRESS; Initial Catalog = finalTP2; Integrated Security = true");
            adaptador = new SqlDataAdapter();

            SqlCommand alta = new SqlCommand("INSERT INTO usuarios VALUES (@nombre, @apellido, @fecha_nacimiento, @numero_celular, @mail)", conexion);
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fecha_nacimiento", SqlDbType.Date));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numero_celular", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@mail", SqlDbType.VarChar));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adaptador.InsertCommand.Parameters["@nombre"].Value = nombre_txt.Text;
            adaptador.InsertCommand.Parameters["@apellido"].Value = apellido_txt.Text;
            adaptador.InsertCommand.Parameters["@fecha_nacimiento"].Value = fecha_dtp.Value;
            adaptador.InsertCommand.Parameters["@numero_celular"].Value = celular_txt.Text;
            adaptador.InsertCommand.Parameters["@mail"].Value = mail_txt.Text;
            try
            {
                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("El Usuario se cargo correctamente");
                limpiar();
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
                    nombre_txt.Focus();
                }
            }
        }


    }
}
