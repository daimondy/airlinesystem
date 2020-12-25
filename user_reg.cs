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

namespace airlinesystem
{
    public partial class user_reg : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wisep\source\repos\airlinesystem\Database1.mdf;Integrated Security=True");
        public user_reg()
        {
            InitializeComponent();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            new autorisation().Show();
            Hide();
        }

        private void buttonSingUp_Click(object sender, EventArgs e)
        {
            string firstname = textBoxFirstN.Text;
            string lastname = textBoxLastN.Text;
            string middlename = textBoxMiddleN.Text;
            string contact_num = textBoxContNum.Text;
            string email = textBoxEmail.Text;
            string date = dateTimePicker1.Text;
            string username = textBoxUserN.Text;
            string password = textBoxPassword.Text;
            string sex = comboBoxSex.Text;
            string pass_num = textBoxPass_num.Text;
            string country = textBoxCounrty.Text;
            string city = textBoxCity.Text;
            string street = textBoxStreet.Text;
            string zip_code = textBoxZipCode.Text;


            conn.Open();

            string query = "INSERT INTO [passenger_lp] (username, password) VALUES (@uN, @pS) " +
                "INSERT INTO [passenger_contact] (phone_number, email) VALUES ( @p, @eM)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@uN", username);
            command.Parameters.AddWithValue("@pS", password);
            command.Parameters.AddWithValue("@p", contact_num);
            command.Parameters.AddWithValue("@eM", email);

            command.ExecuteNonQuery();

            conn.Close();

            new autorisation().Show();
            Hide();
        }
    }
}
