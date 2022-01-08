using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ConnectionBD
{
    internal class ConexionPgSQL
    {
        NpgsqlConnection conn = new NpgsqlConnection(
            "Server = localhost; " +
            "User Id=postgres; " +
            "Password = 123; " +
            "Database = colors");

        public void connect()
        {
            conn.Open();
            System.Windows.Forms.MessageBox.Show("BD connected");
        }
        public void disconnect()
        {
            conn.Close();
            System.Windows.Forms.MessageBox.Show("BD disconnected");
        }

    }
}
