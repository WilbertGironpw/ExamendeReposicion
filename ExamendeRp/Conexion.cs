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
using System.IO;

namespace ExamendeRp
{
    class Conexion
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_parque_vehicular_primer_apellido_primer_nombre.mdf;Integrated Security=True";

        public void EjecutarConsulta(string query)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
