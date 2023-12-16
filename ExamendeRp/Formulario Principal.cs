using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using ExamendeRp.Properties;

namespace ExamendeRp
{
    public partial class FormularioDeDatos : Form
    {
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();
        private Conexion conexion;

        public FormularioDeDatos()
        {
            InitializeComponent();
            conexion = new Conexion();
            {
                miTabla = new DataTable();
                miTabla.Columns.Add("marca", typeof(string));
                miTabla.Columns.Add("modelo", typeof(string));
                miTabla.Columns.Add("year", typeof(string));
                miTabla.Columns.Add("num_motor", typeof(string));
                miTabla.Columns.Add("num_chasis", typeof(string));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datasetAdm.tbl_vehiculos' Puede moverla o quitarla según sea necesario.
            this.tbl_vehiculosTableAdapter.Fill(this.datasetAdm.tbl_vehiculos);

        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtYear.Text, out int year))
            {
                // Obtén los demás datos de los TextBox
                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;
                string numMotor = txtNumMotor.Text;
                string numChasis = txtNumChasis.Text;

                if (marca.Length == 1)
                {
                    MessageBox.Show("Datos invalidos.");
                    return;
                }
                if (modelo.Length == 1)
                {
                    MessageBox.Show("Datos invalidos.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtYear.Text))
                {
                    MessageBox.Show("Datos invalidos.");
                    return;
                }

                if (numMotor.Length == 2)
                {
                    MessageBox.Show("Datos invalidos.");
                    return;
                }
                if (numChasis.Length == 2)
                {
                    MessageBox.Show("Datos invalidos.");
                    return;
                }
            }
            SqlConnection conexion = new SqlConnection(@"Data Source=TuServidor;Initial Catalog=db_parque_vehicular_primer_apellido_primer_nombre;Integrated Security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO tbl_vehiculos (marca, modelo, year, num_motor, num_chasis,) VALUES (@marca, @modelo, @year, @num_motor, @num_chasis,)", conexion);
            comando.Parameters.AddWithValue("@marca", txtMarca);
            comando.Parameters.AddWithValue("@modelo", txtModelo);
            comando.Parameters.AddWithValue("@year", txtYear);
            comando.Parameters.AddWithValue("@num_motor", txtNumMotor);
            comando.Parameters.AddWithValue("@num_chasis", txtNumChasis);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Los datos se ingresaron correctamente");

            DataRow nuevaFila = miTabla.NewRow();
            nuevaFila["marca"] = txtMarca;
            nuevaFila["modelo"] = txtModelo;
            nuevaFila["year"] = txtYear;
            nuevaFila["num_motor"] = txtNumMotor ;
            nuevaFila["num_chasis"] =txtNumChasis;
            miTabla.Rows.Add(nuevaFila);

            mostrarDatos();
        }

        private void mostrarDatos()
        {
            throw new NotImplementedException();
        }
    }
}
