using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExamendeRp
{
    public partial class FormularioDeDatos : Form
    {
        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_parque_vehicular_primer_apellido_primer_nombre.mdf;Integrated Security=True";

        public FormularioDeDatos()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT IdVehiculo as IdVehiculo, marca as Marca, modelo as Modelo, year as Year, num_motor as Num_motor, num_chasis as Num_chasis FROM tbl_vehiculos", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].ReadOnly = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int totalFilasAgregadas = 0;

            // Obtener datos desde los TextBox
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string year = txtYear.Text;
            string num_motor = txtNumMotor.Text;
            string num_chasis = txtNumChasis.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Verificar si la fila ya existe en la base de datos
                SqlCommand verificarExistencia = new SqlCommand("SELECT COUNT(*) FROM tbl_vehiculos WHERE CAST(marca AS NVARCHAR(MAX)) = @marca AND CAST(modelo AS NVARCHAR(MAX)) = @modelo AND CAST(year AS NVARCHAR(MAX)) = @year AND CAST(num_motor AS NVARCHAR(MAX)) = @num_motor AND CAST(num_chasis AS NVARCHAR(MAX)) = @num_chasis", conn);

                verificarExistencia.Parameters.AddWithValue("@marca", marca);
                verificarExistencia.Parameters.AddWithValue("@modelo", modelo);
                verificarExistencia.Parameters.AddWithValue("@year", year);
                verificarExistencia.Parameters.AddWithValue("@num_motor", num_motor);
                verificarExistencia.Parameters.AddWithValue("@num_chasis", num_chasis);

                int rowCount = Convert.ToInt32(verificarExistencia.ExecuteScalar());

                if (rowCount == 0)
                {
                    // La fila no existe, insertarla
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbl_vehiculos (marca, modelo, year, num_motor, num_chasis) VALUES (@marca, @modelo, @year, @num_motor, @num_chasis)", conn);
                    cmd.Parameters.AddWithValue("@marca", marca);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@num_motor", num_motor);
                    cmd.Parameters.AddWithValue("@num_chasis", num_chasis);

                    int filasAgregadas = cmd.ExecuteNonQuery();
                    totalFilasAgregadas += filasAgregadas;
                }
                else
                {
                    // La fila ya existe, podrías manejarlo según tus necesidades
                    // Puedes mostrar un mensaje, actualizar la fila existente, etc.
                    MessageBox.Show($"La fila con los datos ingresados ya existe.", "Mensaje!!");
                }
            }

            MessageBox.Show($"Filas añadidas: {totalFilasAgregadas}", "Mensaje!!");
            totalFilasAgregadas = 0;
            LoadData(); // Recargar datos
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}