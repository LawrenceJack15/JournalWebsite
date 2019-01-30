using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace JournalWebsite
{
    class Access
    {
        public static string connection = "Data Source=LAPTOP-7KGTFNDJ\\SQLEXPRESS;Initial Catalog=Digital Journal;Integrated Security=True";
        SqlConnection JournalWebsite = new SqlConnection(connection);

        public bool login(string user, string password)
        {
            string query = $"SELECT [Username], [Password] FROM [Users] WHERE [Username] = '{user}' AND [Password] = '{password}'";

            SqlDataAdapter data = new SqlDataAdapter(query, JournalWebsite);

            DataTable table = new DataTable();

            data.Fill(table);

            if (table.Rows.Count == 1)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        public bool register(string user, string password)
        {
            string query = $"SELECT [Username] FROM [Users] WHERE [Username] = '{user}'";

            SqlDataAdapter data = new SqlDataAdapter(query, JournalWebsite);

            DataTable table = new DataTable();

            data.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Taken");
                return false;
            }

            else
            {
                string query2 = "INSERT INTO [Users] ([Username], [Password]) VALUES (@user, @pass)";

                JournalWebsite.Open();

                SqlCommand cmd = new SqlCommand(query2, JournalWebsite);


                cmd.Parameters.AddWithValue("@user",1);

                cmd.ExecuteNonQuery();

                JournalWebsite.Close();

                MessageBox.Show("Updated");

            }
        }
    }
}
