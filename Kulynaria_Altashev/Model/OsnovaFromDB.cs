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
    internal class OsnovaFromDB
    {
        public static List<Osnova> loadOsnovas()
        {
            List<Osnova> osnovas = new List<Osnova>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT osnova "
                    + "FROM public.bluda";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        osnovas.Add(new Osnova( reader[0].ToString() ));
                    }
                }
                reader.Close();
                return osnovas;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return osnovas;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
