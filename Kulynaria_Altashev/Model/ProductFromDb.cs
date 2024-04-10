using Kulynaria_Altashev.Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kulynaria_Altashev.Model
{
    internal class ProductFromDb
    {
        public static List<Product> loadProducts()
        {
            List<Product> products = new List<Product>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT identificator, product, belki, zhire, uglev "
                    + "FROM public.products";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        products.Add(new Product((int)reader[0], reader[1].ToString(), (int)reader[2], (int)reader[3], (int)reader[4]));
                    }
                }
                reader.Close();
                return products;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return products;
            }
            finally
            {
                connection.Close();
            }
        }


        public static List<Product> loadProductsOn(string sql)
        {
            List<Product> products = new List<Product>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        products.Add(new Product((int)reader[0], reader[1].ToString(), (int)reader[2], (int)reader[3], (int)reader[4]));
                    }
                }
                reader.Close();
                return products;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return products;
            }
            finally
            {
                connection.Close();
            }
        }


        public static void ProductAdd(string productName, string Belki, string Zhire, string Uglev)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            int belki = System.Convert.ToInt32(Belki);
            int zhire = System.Convert.ToInt32(Zhire);
            int uglev = System.Convert.ToInt32(Uglev);
            try
            {
                connect.Open();
                string sqlExp = "INSERT INTO public.products(product, belki, zhire, uglev) " +
                    "VALUES (@productName,@Belki,@Zhire,@Uglev)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("productName", productName);
                cmd1.Parameters.AddWithValue("Belki", belki);
                cmd1.Parameters.AddWithValue("Zhire", zhire);
                cmd1.Parameters.AddWithValue("Uglev", uglev);
                int i = cmd1.ExecuteNonQuery();
                if (i == 1) { MessageBox.Show("Продукт успешно добавлен"); }
                else MessageBox.Show("Ошибка записи");
            }
            catch (NpgsqlException ex)
            { MessageBox.Show(ex.Message); return; }
            connect.Close();
        }

        public static void DeleteProduct(int identificator)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();
                string sqlExp = "DELETE FROM public.products where identificator = @identificator ";

                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("identificator", identificator);
                int i = cmd1.ExecuteNonQuery();
                if (i == 1) { MessageBox.Show("Продукт удален удален"); }
                else MessageBox.Show("Ошибка удаления");

            }
            catch (NpgsqlException ex)
            { MessageBox.Show(ex.Message); return; }
            connect.Close();


        }

    }
}
