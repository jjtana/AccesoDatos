using System;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class SqlClient
    {
        // Cadena de conexión a la base de datos
        private string connectionString = "Server=DESKTOP-RNITKSE;Database=AgendaDBS;Integrated Security=True;";

        // Método para obtener todos los registros de la tabla Contacts
        public DataTable GetAllContacts()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Contacts";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener contactos: " + ex.Message);
                }
            }
            return dataTable;
        }

        // Método para insertar un nuevo registro
        public void InsertContact(string nombre, string apellido, DateTime fechaNacimiento, string direccion, string genero, string estadoCivil, string movil, string telefono, string correoElectronico)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Contacts (Nombre, Apellido, FechaNacimiento, Direccion, Genero, EstadoCivil, Movil, Telefono, CorreoElectronico) " +
                                   "VALUES (@Nombre, @Apellido, @FechaNacimiento, @Direccion, @Genero, @EstadoCivil, @Movil, @Telefono, @CorreoElectronico)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Apellido", apellido);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                        cmd.Parameters.AddWithValue("@Direccion", direccion);
                        cmd.Parameters.AddWithValue("@Genero", genero);
                        cmd.Parameters.AddWithValue("@EstadoCivil", estadoCivil);
                        cmd.Parameters.AddWithValue("@Movil", movil);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar contacto: " + ex.Message);
                }
            }
        }

        // Método para actualizar un registro existente
        public void UpdateContact(Contact contact)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Contacts SET Nombre = @Nombre, Apellido = @Apellido, FechaNacimiento = @FechaNacimiento, Direccion = @Direccion, " +
                                   "Genero = @Genero, EstadoCivil = @EstadoCivil, Movil = @Movil, Telefono = @Telefono, CorreoElectronico = @CorreoElectronico " +
                                   "WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", contact.Id);
                        cmd.Parameters.AddWithValue("@Nombre", contact.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", contact.Apellido);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", contact.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@Direccion", contact.Direccion);
                        cmd.Parameters.AddWithValue("@Genero", contact.Genero);
                        cmd.Parameters.AddWithValue("@EstadoCivil", contact.EstadoCivil);
                        cmd.Parameters.AddWithValue("@Movil", contact.Movil);
                        cmd.Parameters.AddWithValue("@Telefono", contact.Telefono);
                        cmd.Parameters.AddWithValue("@CorreoElectronico", contact.CorreoElectronico);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar contacto: " + ex.Message);
                }
            }
        }

        // Método para eliminar un registro
        public void DeleteContact(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Contacts WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar contacto: " + ex.Message);
                }
            }
        }
    }
}