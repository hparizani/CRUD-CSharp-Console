using System;
using System.Data.SqlClient;

namespace console_crud
{
    internal class Product
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }

        public bool registrerProduct(Product product)
        {
            try
            {
                string connectionString = @"Data Source=HPARIZANI;Initial Catalog=PIM;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO [dbo].[Product]([name],[quantity],[description],[price]) VALUES (@Name, @Quantity, @Description, @Price)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", product.name);
                        command.Parameters.AddWithValue("@Quantity", product.quantity);
                        command.Parameters.AddWithValue("@Description", product.description);
                        command.Parameters.AddWithValue("@Price", product.price);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
