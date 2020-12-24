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

namespace airlinesystem
{
    public partial class registration : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wisep\source\repos\airlinesystem\Database1.mdf;Integrated Security=True");
        public registration()
        {
            InitializeComponent();
        }
        
        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            
            conn.Open();

            string query = "INSERT INTO [admin] (username, password, first_name, last_name, middle_name, contact_number, email, date_of_birth) " +
                "VALUES (@uN, @pS, @fN, @lN, @mN, @cN, @eml, @date)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@uN", username);
            command.Parameters.AddWithValue("@pS", password);
            command.Parameters.AddWithValue("@fN", firstname);
            command.Parameters.AddWithValue("@lN", lastname);
            command.Parameters.AddWithValue("@mN", middlename);
            command.Parameters.AddWithValue("@cN", contact_num);
            command.Parameters.AddWithValue("@eml", email);
            command.Parameters.AddWithValue("@date", date);

            command.ExecuteNonQuery();

            conn.Close();

            new autorisation().Show();
            Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            new autorisation().Show();
            Hide();
        }
    }
}
