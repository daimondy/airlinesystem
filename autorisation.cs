using System;
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

namespace airlinesystem
{
    public partial class autorisation : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wisep\source\repos\airlinesystem\Database1.mdf;Integrated Security=True");

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

                string result = Microsoft.VisualBasic.Interaction.InputBox("Введите пароль: ", "Пароль для администратора");
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
                new user_dash().Show();
                Hide();
            }
           
        }

        private void buttonSingUp_Click(object sender, EventArgs e)
        {
            new registration().Show();
            Hide();
        }

        private void autorisation_Load(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
