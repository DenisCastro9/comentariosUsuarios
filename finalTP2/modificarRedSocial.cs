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
    public partial class modificarRedSocial : Form
    {
        public modificarRedSocial()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos;

        private void modificarRedSocial_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source = DESKTOP-TDSHAI5\\SQLEXPRESS; Initial Catalog = finalTP2; Integrated Security = true");
            adaptador = new SqlDataAdapter();
            datos = new DataSet();

            SqlCommand consultarR = new SqlCommand("SELECT * FROM redSocial WHERE id_redSocial = @id_redSocial", conexion);
            adaptador.SelectCommand = consultarR;
            adaptador.SelectCommand.Parameters.Add(new SqlParameter("@id_redSocial", SqlDbType.Int));

            SqlCommand modificarR = new SqlCommand("UPDATE redSocial SET nombre = @nombre, descripcion = @descripcion", conexion);
            adaptador.UpdateCommand = modificarR;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idR_txt.Text))
            {
                MessageBox.Show("Es necesario ingresar un ID de una red social cargada");
            }
            else
            {
                try
                {
                    conexion.Open();
                    adaptador.SelectCommand.Parameters["@id_redSocial"].Value = int.Parse(idR_txt.Text);
                    adaptador.Fill(datos, "redSocial");
                    int registro = int.Parse(datos.Tables["redSocial"].Rows.Count.ToString());
                    if (registro == 1)
                    {
                        foreach (DataRow fila in datos.Tables["redSocial"].Rows)
                        {
                            nombreR_txt.Text = fila["nombre"].ToString();
                            descripcionR_txt.Text = fila["descripcion"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El ID ingresado no existe");
                    }
                }
                catch (SqlException excepcion)
                {
                    MessageBox.Show(excepcion.ToString());
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adaptador.UpdateCommand.Parameters["@nombre"].Value = nombreR_txt.Text;
            adaptador.UpdateCommand.Parameters["@descripcion"].Value = descripcionR_txt.Text;
            try
            {
                conexion.Open();
                adaptador.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("La red social se modifico correctamente");
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
