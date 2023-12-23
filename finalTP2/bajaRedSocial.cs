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
    public partial class bajaRedSocial : Form
    {
        public bajaRedSocial()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;

        private void bajaRedSocial_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source = DESKTOP-TDSHAI5\\SQLEXPRESS; Initial Catalog = finalTP2; Integrated Security = true");
            adaptador = new SqlDataAdapter();

            SqlCommand bajar = new SqlCommand("DELETE FROM redSocial where id_redSocial = @id_redSocial", conexion);
            adaptador.DeleteCommand = bajar;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@id_redSocial", SqlDbType.Int));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adaptador.DeleteCommand.Parameters["@id_reSocial"].Value = id_txt.Text;
            try
            {
                conexion.Open();
                int cant = adaptador.DeleteCommand.ExecuteNonQuery();
                if(cant == 0)
                {
                    MessageBox.Show("La red Social no existe");
                }
                else
                {
                    MessageBox.Show("Se borro la red social Correctamente");
                    id_txt.Text = "";
                    id_txt.Focus();
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
