﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Windows.Input;

namespace airlinesystem
{
    public partial class autorisation : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wisep\source\repos\airlinesystem\Database1.mdf;Integrated Security=True");

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0) && Char.IsLetterOrDigit(e.Text, 0));
         }
        public autorisation()
        {
            InitializeComponent();
        }

        
        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            //для админа
            if (checkBox1.Checked)
            {
                conn.Open();

                string username, password;
                username = textBoxLogin.Text;
                password = textBoxPassword.Text;

<<<<<<< HEAD
                string result = Microsoft.VisualBasic.Interaction.InputBox("Введите ключ доступа: ", "Доступ");
=======


                string result = Microsoft.VisualBasic.Interaction.InputBox("Введите пароль: ", "Пароль для администратора");
>>>>>>> 21729aab75e1fae98a5cce56a9dc10f8d8a7ffc5
                if (result == "0")
                {
                    
                    string query = "SELECT * FROM [admin] WHERE username = @aU and password = @aP";
                    
                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@aU", username); //указание заглушки логина
                    command.Parameters.AddWithValue("@aP", password); //указание заглушки пароля

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet set = new DataSet();
                    adapter.Fill(set);
                   
                    if ((set.Tables[0].Rows.Count) > 0)
                    {
                        MessageBox.Show("Вы авторизовались", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new dashboard().Show();
                        Hide();
                    }
                    else
                        MessageBox.Show("Проверьте правильность логина и/или пароля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Проверьте правильность пароля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            else
            {
                conn.Open();
<<<<<<< HEAD
                
=======

>>>>>>> 21729aab75e1fae98a5cce56a9dc10f8d8a7ffc5
                string username, password;
                username = textBoxLogin.Text;
                password = textBoxPassword.Text;
               
                string query = "SELECT * FROM [admin] WHERE username = @aU and password = @aP";

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@aU", username); //указание заглушки логина
                command.Parameters.AddWithValue("@aP", password); //указание заглушки пароля

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet set = new DataSet();
                adapter.Fill(set);

                if ((set.Tables[0].Rows.Count) > 0)
                {
                    MessageBox.Show("Вы авторизовались", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    new user_dash().Show();
                    Hide();
                }
                else
                    MessageBox.Show("Проверьте правильность логина и/или пароля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();

            }
           
        }

        private void buttonSingUp_Click(object sender, EventArgs e)
        {
            new registration().Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new dashboard().Show();
            Hide();
        }

        private void buttonSingUpP_Click(object sender, EventArgs e)
        {
            new user_reg().Show();
            Hide();
        }

        private void autorisation_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
           if (checkBox1.Checked)
            {
                buttonSingUp.Visible = true;
                buttonSingUpP.Visible = false;
            }
            else
            {
                buttonSingUp.Visible = false;
                buttonSingUpP.Visible = true;
            }
        }
    }
}
