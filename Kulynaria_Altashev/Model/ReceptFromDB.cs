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
    internal class ReceptFromDB
    {
        public List<Recept> loadRecepts()
        {
            List<Recept> recepts = new List<Recept>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * from rezepti";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        recepts.Add(new Recept((int)reader[0], reader[1].ToString()));
                    }
                }
                reader.Close();
                return recepts;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return recepts;
            }
            finally
            {
                connection.Close();
            }

           
        }
        public void DeleteRecept(int recept_id)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();
                string sqlExp = "DELETE FROM public.rezepti where identityr = @recept ";

                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("recept", recept_id);
                int i = cmd1.ExecuteNonQuery();
                if (i == 1) { MessageBox.Show("Рецепт удален"); }
                else MessageBox.Show("Ошибка удаления");

            }
            catch (NpgsqlException ex)
            { MessageBox.Show(ex.Message); return; }
            connect.Close();


        }


        public static void ReceptAdd(string rec, int id_bluda)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();
                string sqlExp = "INSERT INTO public.rezepti(recept) " +
                    "VALUES (@rec)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("rec", rec);
                cmd1.Parameters.AddWithValue("id", id_bluda);
                int i = cmd1.ExecuteNonQuery();
                if (i == 1) { MessageBox.Show("Вы успешно добавили рецепт "); }
                else MessageBox.Show("Ошибка добавления");
            }
            catch (NpgsqlException ex)
            { MessageBox.Show(ex.Message); return; }
            connect.Close();
        }


        public  void ChangeRecept(string receptura, int recept_id)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();
                string sqlExp = "UPDATE rezepti " +
                               "set recept = @receptura " +
                                "where identityr = @recept_id ";

                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("receptura", receptura);
                cmd1.Parameters.AddWithValue("recept_id", recept_id);
                int i = cmd1.ExecuteNonQuery();
                if (i == 1) { MessageBox.Show("Рецепт изменен"); }
                else MessageBox.Show("Ошибка изменения рецепта");

            }
            catch (NpgsqlException ex)
            { MessageBox.Show(ex.Message); return; }
            connect.Close();


        }

    }
}
