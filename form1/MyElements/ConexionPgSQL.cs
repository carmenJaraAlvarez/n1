using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

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
        public void insert(string n, string c)
        {
            try
            {
                string query = "insert into \"colors\" values (4,'" + n + "','" + c + "')";
                NpgsqlCommand c_i = new NpgsqlCommand(query, conn);
                c_i.ExecuteNonQuery();
            }catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("exception: "+ex.Message);
            }

        }
        public void Drop(string n)
        {
            try { 
                string query = "Delete from \"colors\" where \"name\" = '" + n + "' ";
                NpgsqlCommand c_d = new NpgsqlCommand(query, conn);
                c_d.ExecuteNonQuery();
            }catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("exception: "+ex.Message);
            }

        }
        public void Update(string n, string c)
        {
            try
            {
                string query = "Update \"colors\" set \"hexcode\" =  '" + c + "'where \"name\" = '" + n + "' ";
                NpgsqlCommand c_u = new NpgsqlCommand(query, conn);
                c_u.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("exception: " + ex.Message);
            }
        }

        public DataTable lookfor(string n)
        {
            DataTable res = new DataTable();

            string query = "select * from \"colors\" where \"name\" = '"+n+"'";
            NpgsqlCommand c_s = new NpgsqlCommand(query, conn); 
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(c_s);
            data.Fill(res);
            return res;
        }
    }
}
