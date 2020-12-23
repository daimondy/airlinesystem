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
    public partial class airplane : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wisep\source\repos\airlinesystem\Database1.mdf;Integrated Security=True");
        public airplane()
        {
            InitializeComponent();
            load();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new dashboard().Show();
            Hide();
        }

        private void load()
        {
            conn.Open();

            this.comboBoxID_AC.Items.Clear();
            SqlCommand command = new SqlCommand("SELECT airline_ID FROM [airline]", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                string id = dataset.Tables[0].Rows[i].ItemArray[0].ToString();
                this.comboBoxID_AC.Items.Add(id);
            }
            conn.Close();
        }

        private void save()
        {
            string id_a = textBoxID_A.Text;
            string reg = textBoxReg.Text;
            string seats = textBoxSeats.Text;
            string category = comboBoxCategory.Text;
            string id_ac = comboBoxID_AC.Text;

            conn.Open();

            string query = "INSERT INTO [airplane] (airplane_id, reg_num, seats, category, airline_id) VALUES (@id, @rN, @s, @cat, @airid) ";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id_a);
            command.Parameters.AddWithValue("@rN", reg);
            command.Parameters.AddWithValue("@s", seats);
            command.Parameters.AddWithValue("@cat", category);
            command.Parameters.AddWithValue("@airid", id_ac);

            MessageBox.Show("Сохранено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxID_A.Text = "";
            textBoxReg.Text = "";
            textBoxSeats.Text = "";
            comboBoxCategory.Text = "";
            comboBoxID_AC.Text = "";

            command.ExecuteNonQuery();

            conn.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
