﻿using System;
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

        public Manager_koef()
        {
            InitializeComponent();
            Load();
        }


        private void Load()
        {
            List<string[]> data = new List<string[]>();
            a = null;
            if (Znach.id_login.ToString().Length > 0)
            {
                a = "Select tasks.[ID_tasks],Users.ФИО_cотрудника, tasks.[Заголовок] ,[Сложность] ,[Статус] ,[Характер_работы] FROM[tasks] join Users on tasks.ID_login = Users.ID_login";
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
                            for (int i = 0; i < 6; i++)
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

        private void Manager_koef_Load(object sender, EventArgs e)
        {

        }
    }
}
