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
    public partial class flight : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wisep\source\repos\airlinesystem\Database1.mdf;Integrated Security=True");
        public flight()
        {
            InitializeComponent();
            loadairplane();
            loadcity();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void loadairplane()
        {
            conn.Open();

            this.comboBoxID_P.Items.Clear();
            SqlCommand command = new SqlCommand("SELECT airplane_id, airline_id FROM [airplane]", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                string id = dataset.Tables[0].Rows[i].ItemArray[0].ToString();
                comboBoxID_P.Items.Add(id);
                comboBoxAirline.Items.Add(id);
            }
            conn.Close();
        }

        private void loadcity()
        {
            conn.Open();
            comboBoxDep.Items.Clear();
            comboBoxArr.Items.Clear();
            SqlCommand command = new SqlCommand("SELECT city FROM [airport]", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                string city = dataset.Tables[0].Rows[i].ItemArray[0].ToString();
                comboBoxDep.Items.Add(city);
                comboBoxArr.Items.Add(city);
            }
            conn.Close();
        }

        private void save()
        {
            string id_r = textBoxID_F.Text;
            string id_airp = comboBoxID_P.Text;
            string from = comboBoxDep.Text;
            string to = comboBoxArr.Text;
            string datetimeF = dateTimeDep.Text;
            string datetimeT = dateTimeArr.Text;
            string id_airline = comboBoxAirline.Text;
            string status = comboBoxStatus.Text;
            string pay = textBoxCost.Text;

            conn.Open();

            string query = "INSERT INTO [flight] (flight_id, airplane_id, dep_city, arr_city, dep_datetime, arr_datetime, airline_id, status) VALUES (@idF, @idP, @dC, @aC, @timeD, @timeA, @airL, @s)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@idF", id_r);
            command.Parameters.AddWithValue("@idP", id_airp);
            command.Parameters.AddWithValue("@dC", from);
            command.Parameters.AddWithValue("@aC", to);
            command.Parameters.AddWithValue("@timeD", datetimeF);
            command.Parameters.AddWithValue("@timeA", datetimeT);
            command.Parameters.AddWithValue("@airL", id_airline);
            command.Parameters.AddWithValue("@s", status);

            string query1 = "INSERT INTO [pay] (flight_id, pay) VALUES (@idF, @pay)";
            SqlCommand command1 = new SqlCommand(query1, conn);
            command1.Parameters.AddWithValue("@idF", id_r);
            command1.Parameters.AddWithValue("@pay", pay);


            MessageBox.Show("Сохранено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxID_F.Text = "";
            comboBoxID_P.Text = "";
            comboBoxDep.Text = "";
            comboBoxArr.Text = "";
            dateTimeDep.Text = "";
            dateTimeArr.Text = "";
            comboBoxAirline.Text = "";
            comboBoxStatus.Text = "";
            textBoxCost.Text = "";

            command.ExecuteNonQuery();
            command1.ExecuteNonQuery();

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
