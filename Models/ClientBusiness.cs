using System.Data.SqlClient;
using System.Runtime.CompilerServices;


namespace Models
{
    public class ClientBusiness
    {
        private static string connectionString;       

        static ClientBusiness()
        {
            ClientBusiness.connectionString = "server=.\\SQLEXPRESS; database=INTEGRADOR; integrated security=true";
        }

        public static List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT id, dni, first_name, last_name, age, phone, inscriptionDate, limitDate FROM PERSONA";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {     
                            int id = (int)reader["id"];                            
                            string dni = (string)reader["dni"];
                            string first_name = (string)reader["first_name"];
                            string last_name = (string)reader["last_name"];
                            int age = (int)reader["age"];
                            string phone = (string)reader["phone"];
                            DateTime inscriptionDate = (DateTime)reader["inscriptionDate"];
                            DateTime limitDate = (DateTime)reader["limitDate"];                          
                          

                            Client client = new Client(id, dni, first_name, last_name, age, phone, EGenre.MALE, inscriptionDate, limitDate);
                            
                            clients.Add(client);                         
                            
                            
                        }
                    }
                    return clients;
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Algo salió mal al listar los clientes: " + ex.Message);
                throw;
            }
        }

       

        public static bool Edit(Client client)
        {            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    string query = $"UPDATE PERSONA SET first_name='{client.FirstName}', last_name='{client.LastName}', dni='{client.Dni}', age='{client.Age}', phone='{client.Phone}' WHERE id = {client.Id}";
                   
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@FirstName", client.FirstName);
                        command.Parameters.AddWithValue("@LastName", client.LastName);
                        command.Parameters.AddWithValue("@Dni", client.Dni);
                        command.Parameters.AddWithValue("@Phone", client.Phone);
                        command.Parameters.AddWithValue("@Age", client.Age);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static int DeleteClient(int id)
        {
            try
            {
                string query = "DELETE FROM PERSONA WHERE id = @id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                        return 1;
                    }
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el cliente: " + ex.Message);
                return 0;
            }
        }          

        public static void SaveClient(Client client)
        {
            try
            {
                string query = "INSERT INTO PERSONA (first_name, last_name, age, phone, dni, inscriptionDate, limitDate) VALUES (@FirstName, @LastName, @Age, @Phone, @Dni, @InscriptionDay, @LimitDay)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", client.FirstName);
                        command.Parameters.AddWithValue("@LastName", client.LastName);
                        command.Parameters.AddWithValue("@Age", client.Age);
                        command.Parameters.AddWithValue("@Phone", client.Phone);
                        command.Parameters.AddWithValue("@Dni", client.Dni);
                        command.Parameters.AddWithValue("@InscriptionDay", client.InscriptionDate);
                        command.Parameters.AddWithValue("@LimitDay", client.LimitDate);

                        connection.Open();
                        command.ExecuteNonQuery();              

                    }
                }               
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el cliente: " + ex.Message);
                throw;
            }
        }       
    }
}