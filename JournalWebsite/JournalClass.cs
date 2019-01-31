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
    class JournalClass
    {
        static string connection = "Data Source=LAPTOP-7KGTFNDJ\\SQLEXPRESS;Initial Catalog=Digital Journal;Integrated Security=True";
        SqlConnection JournalWebsite = new SqlConnection(connection);
        public bool addJournal(string Title, string Entry)
        {
            string SELECT = $"SELECT [[Title] FROM [Journal entries] WHERE [Title] = '{Title}'";
            string ADD = $"INSERT INTO[Journal entries] ([Title], [Entry]) VALUES(@title, @entry)";
            SqlDataAdapter addj = new SqlDataAdapter(SELECT, JournalWebsite);
            DataTable table = new DataTable();
            addj.Fill(table);
            if (table.Rows.Count == 1)
            {
                return false;
            }
            else
            {
                SqlCommand command = new SqlCommand(ADD, JournalWebsite);
                command.Parameters.AddWithValue("@title", Title);
                command.Parameters.AddWithValue("@entry", Entry);
                JournalWebsite.Open();
                command.ExecuteNonQuery();
                JournalWebsite.Close();
                return true;
            }


        }
    }
}
