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
    public partial class baja_usuario : Form
    {
        public baja_usuario()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;

        private void baja_usuario_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source = DESKTOP-TDSHAI5\\SQLEXPRESS; Initial Catalog = finalTP2; Integrated Security = true");
            adaptador = new SqlDataAdapter();

            SqlCommand baja = new SqlCommand("DELETE FROM usuarios WHERE id_usuario = @id_usuario", conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@id_usuario", SqlDbType.Int));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adaptador.DeleteCommand.Parameters["@id_usuario"].Value = textBox1.Text;
            try
            {
                conexion.Open();
                int cant = adaptador.DeleteCommand.ExecuteNonQuery();
                if(cant == 0)
                {
                    MessageBox.Show("El usuario no existe");
                }
                else
                {
                    MessageBox.Show("Se Elimino al Usuario correctamente");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
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
    }
}
