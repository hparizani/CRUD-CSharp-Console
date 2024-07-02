using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace console_crud
{
    public class Product
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int id { get; set; }
        // CREATE
        public bool registrerProduct(Product product)
        {
            try
            {
                string connectionString = @"Data Source=HPARIZANI;Initial Catalog=PIM;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryInsert = "INSERT INTO [dbo].[Product]([name],[quantity],[description],[price]) VALUES (@Name, @Quantity, @Description, @Price)";

                    using (SqlCommand command = new SqlCommand(queryInsert, connection))
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
        // READ
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                string connectionString = @"Data Source=HPARIZANI;Initial Catalog=PIM;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand selectCommand = new SqlCommand("SELECT * FROM Product", connection);

                    connection.Open();

                    SqlDataReader reader = selectCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.id = Convert.ToInt16(reader["Id"]);
                        product.name = reader["Name"].ToString();
                        product.quantity = Convert.ToInt16(reader["Quantity"]);
                        product.description = reader["Description"].ToString();
                        product.price = Convert.ToDecimal(reader["Price"]);

                        products.Add(product);
                    }
                }
                return products;
            }
            catch (Exception)
            {
                throw;
            }
        }
        // UPDATE
        public bool updateProduct(Product product)
        {
            try
            {
                string connectionString = @"Data Source=HPARIZANI;Initial Catalog=PIM;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand updateCommand = new SqlCommand("UPDATE Product SET name = @Name, quantity = @Quantity, description = @Description, price = @Price WHERE id = @Id", connection);

                    updateCommand.Parameters.AddWithValue("@Name", product.name);
                    updateCommand.Parameters.AddWithValue("@Quantity", product.quantity);
                    updateCommand.Parameters.AddWithValue("@Description", product.description);
                    updateCommand.Parameters.AddWithValue("@Price", product.price);
                    updateCommand.Parameters.AddWithValue("@Id", product.id);

                    if (updateCommand.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        // DELETE
        public bool deleteProduct(Product product)
        {
            try
            {
                string connectionString = @"Data Source=HPARIZANI;Initial Catalog=PIM;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand deleteCommand = new SqlCommand("DELETE Product WHERE id = @Id", connection);

                    deleteCommand.Parameters.AddWithValue("@Id", product.id);

                    if (deleteCommand.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
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
