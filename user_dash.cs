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

//ПОнять как сделать таблицу рейсов чтобы было в одну строку!!


namespace airlinesystem
{
    public partial class user_dash : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wisep\source\repos\airlinesystem\Database1.mdf;Integrated Security=True");
        public user_dash()
        {
            InitializeComponent();
            populateGrid();
        }

        private void populateGrid()
        {
            conn.Open();
            viewGrid.Columns[0].Visible = false;
            viewGrid.Columns[1].Visible = true;
            viewGrid.Columns[2].Visible = true;
            viewGrid.Columns[3].Visible = true;
            viewGrid.Columns[4].Visible = false;
            viewGrid.Columns[5].Visible = true;
            viewGrid.Columns[6].Visible = true;
            SqlCommand cmd = new SqlCommand("SELECT * FROM [airport]", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                string id = dataset.Tables[0].Rows[i].ItemArray[0].ToString();
                string name = dataset.Tables[0].Rows[i].ItemArray[1].ToString();
                string city = dataset.Tables[0].Rows[i].ItemArray[2].ToString();
                string country = dataset.Tables[0].Rows[i].ItemArray[3].ToString();

                DataGridViewRow dataPush = new DataGridViewRow();
                dataPush.CreateCells(viewGrid);
                dataPush.Cells[0].Value = id;
                dataPush.Cells[1].Value = name;
                dataPush.Cells[2].Value = city;
                dataPush.Cells[3].Value = country;
                viewGrid.Rows.Add(dataPush);
            }
            
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM [flight]", conn);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            adapter2.Fill(dataset);

            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                string arr = dataset.Tables[0].Rows[i].ItemArray[5].ToString();
                string dep = dataset.Tables[0].Rows[i].ItemArray[6].ToString();

                DataGridViewRow dataPush = new DataGridViewRow();
                dataPush.CreateCells(viewGrid);
                dataPush.Cells[5].Value = arr;
                dataPush.Cells[6].Value = dep;
                viewGrid.Rows.Add(dataPush);
            }
            conn.Close(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new autorisation().Show();
            Hide();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
