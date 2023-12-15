using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace ExamendeRp
{
    public class Conexion
    {
        private SqlConnection sqlConnection;
        private string connectionString = "Data Source=TuServidor;Initial Catalog=db_parque_vehicular_primer_apellido_primer_nombre;Integrated Security=True";

        public Conexion()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public DataTable BuscarVehiculos(string marca, string modelo, int year, string numMotor, string numChasis)
        {
            DataTable dataTable = new DataTable();

            try
            {
                sqlConnection.Open();
                string query = "SELECT * FROM tbl_vehiculos WHERE marca LIKE @marca AND modelo LIKE @modelo AND year = @year AND num_motor LIKE @numMotor AND num_chasis LIKE @numChasis";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@marca", "%" + marca + "%");
                    sqlCommand.Parameters.AddWithValue("@modelo", "%" + modelo + "%");
                    sqlCommand.Parameters.AddWithValue("@year", year);
                    sqlCommand.Parameters.AddWithValue("@numMotor", "%" + numMotor + "%");
                    sqlCommand.Parameters.AddWithValue("@numChasis", "%" + numChasis + "%");

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones
            }
            finally
            {
                sqlConnection.Close();
            }

            return dataTable;
        }

        public void AdministrarVehiculos(string marca, string modelo, int year, string numMotor, string numChasis, string accion, int idVehiculo = 0)
        {
            try
            {
                sqlConnection.Open();
                string query = "";

                if (accion == "INSERT")
                {
                    query = "INSERT INTO tbl_vehiculos (marca, modelo, year, num_motor, num_chasis) VALUES (@marca, @modelo, @year, @numMotor, @numChasis)";
                }
                else if (accion == "UPDATE")
                {
                    query = "UPDATE tbl_vehiculos SET marca = @marca, modelo = @modelo, year = @year, num_motor = @numMotor, num_chasis = @numChasis WHERE idVehiculo = @idVehiculo";
                }
                else if (accion == "DELETE")
                {
                    query = "DELETE FROM tbl_vehiculos WHERE idVehiculo = @idVehiculo";
                }

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@marca", marca);
                    sqlCommand.Parameters.AddWithValue("@modelo", modelo);
                    sqlCommand.Parameters.AddWithValue("@year", year);
                    sqlCommand.Parameters.AddWithValue("@numMotor", numMotor);
                    sqlCommand.Parameters.AddWithValue("@numChasis", numChasis);
                    sqlCommand.Parameters.AddWithValue("@idVehiculo", idVehiculo);

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}