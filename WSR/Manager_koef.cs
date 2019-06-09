using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR
{
    public partial class Manager_koef : Form
    {

        SqlConnection sqlcon;
        SqlCommand command;
        string a;
        SqlDataReader reader;
        public List<string[]> data;

        public Manager_koef()
        {
            InitializeComponent();
            Load();
            int i = 0;
            foreach (string[] s in data)
            {

                Load_kl(data[i][0], i);
                i = i + 1;
            }
        }


        private void Load()
        {
            data = new List<string[]>();
            a = null;
            if (Znach.id_login.ToString().Length > 0)
            {
                a = "Select Distinct Users.ID_login, Users.ФИО_cотрудника, Koef.Грейд_исполнителя From Users join tasks on Users.ID_login = tasks.ID_login join Koef on Users.ID_login = Koef.ID_login";
                /*Where Users.ID_manager = '" + Znach.id_login +"*/
            }
            using (sqlcon = new SqlConnection(Znach.connectionString))
                try
                {
                    sqlcon.Open();
                    command = new SqlCommand(a, sqlcon);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            data.Add(new string[100]);
                            for (int i = 0; i < 3; i++)
                            {
                                data[data.Count - 1][i] = reader[i].ToString();
                            }
                        }
                    }
                    else
                    {

                        MessageBox.Show("Ошибка");
                    }
            }
                finally
                {
                    reader.Close();
                    sqlcon.Close();
                    sqlcon.Dispose();
                    foreach (string[] s in data)
                        dataGridView1.Rows.Add(s);
                }
        }

        public void Load_kl(string s, int st)
        {
            a = null;
            if (s.Length > 0)
            {
                a = "SELECT COUNT(tasks.ID_login) FROM tasks Where ID_login = '" + s + "'";
                /*Where Users.ID_manager = '" + Znach.id_login +"*/
            }
            using (sqlcon = new SqlConnection(Znach.connectionString))
                try
                {
                    sqlcon.Open();
                    command = new SqlCommand(a, sqlcon);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridView1[3, st].Value = reader[0].ToString();
                        }
                    }
                    else
                    {

                        MessageBox.Show("Ошибка");
                    }
                }
                finally
                {
                    reader.Close();
                    sqlcon.Close();
                    sqlcon.Dispose();
                }
        }

        private void Manager_koef_Load(object sender, EventArgs e)
        {

        }
    }
}
