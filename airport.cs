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
    
    public partial class airport : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wisep\source\repos\airlinesystem\Database1.mdf;Integrated Security=True");
        public airport()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            string id_a = textBoxID_A.Text;
            string name_a = textBoxName_A.Text;
            string country = textBoxCountry.Text;
            string city = textBoxCity.Text;

            conn.Open();

            string query = "INSERT INTO [airport] (airport_id, airport_name, country, city) VALUES (@id, @nM, @cO, @cI) ";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id_a);
            command.Parameters.AddWithValue("@nM", name_a);
            command.Parameters.AddWithValue("@cO", country);
            command.Parameters.AddWithValue("@cI", city);

            MessageBox.Show("Сохранено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxID_A.Text = "";
            textBoxName_A.Text = "";
            textBoxCountry.Text = "";
            textBoxCity.Text = "";

            command.ExecuteNonQuery();

            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new dashboard().Show();
            Hide();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
