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
    public partial class airline : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wisep\source\repos\airlinesystem\Database1.mdf;Integrated Security=True");
        public airline()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            string ID_A = textBoxID_A.Text;
            string Name_A = textBoxName_A.Text;
            string Count_A = textBoxCount_A.Text;

            conn.Open();

            string query = "INSERT INTO [airline] (airline_id, airline_name, airplanes) VALUES (@id, @nM, @aP) ";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", ID_A);
            command.Parameters.AddWithValue("@nM", Name_A);
            command.Parameters.AddWithValue("@aP", Count_A);

            MessageBox.Show("Сохранено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxID_A.Text = "";
            textBoxName_A.Text = "";
            textBoxCount_A.Text = "";

            command.ExecuteNonQuery();

            conn.Close();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new dashboard().Show();
            Hide();
        }
    }
}
