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
    public partial class altaRedSocial : Form
    {
        public altaRedSocial()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;

        private void altaRedSocial_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source = DESKTOP-TDSHAI5\\SQLEXPRESS; Initial Catalog = finalTP2; Integrated Security = true");
            adaptador = new SqlDataAdapter();

            SqlCommand altar = new SqlCommand("INSERT INTO redSocial VALUES (@nombre, @descripcion)", conexion);
            adaptador.InsertCommand = altar;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adaptador.InsertCommand.Parameters["@nombre"].Value = nombreRed_txt.Text;
            adaptador.InsertCommand.Parameters["@descripcion"].Value = descripcion_txt.Text;
            try
            {
                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("La red social se cargo correctamente");
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
                    nombreRed_txt.Focus();
                }
            }
        }
    }
}
