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

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timer1_Tick;
            timer.Enabled = true;

        }

        private void populateGrid()
        {
            conn.Open();
            viewGrid.Columns[0].Visible = true;//рейс
            viewGrid.Columns[1].Visible = false;
            viewGrid.Columns[2].Visible = false;
            viewGrid.Columns[3].Visible = true;// город отпрления
            viewGrid.Columns[4].Visible = true;//город
            viewGrid.Columns[5].Visible = true;//время
            viewGrid.Columns[6].Visible = true;//время
            viewGrid.Columns[7].Visible = true;//статус
            viewGrid.Columns[8].Visible = false;
            viewGrid.Columns[9].Visible = true;//название
            viewGrid.Columns[10].Visible = false;
            viewGrid.Columns[11].Visible = false;
            viewGrid.Columns[12].Visible = false;
            viewGrid.Columns[13].Visible = true;//цена
            SqlCommand cmd = new SqlCommand("SELECT * FROM [flight] JOIN [airline] ON  flight.airline_id = airline.airline_id " +
                                                                   "JOIN [pay] ON pay.flight_id = flight.flight_id", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                string id_flight = dataset.Tables[0].Rows[i].ItemArray[0].ToString();
                string city_arr = dataset.Tables[0].Rows[i].ItemArray[3].ToString();
                string city_dep = dataset.Tables[0].Rows[i].ItemArray[4].ToString();
                string dt_arr = dataset.Tables[0].Rows[i].ItemArray[5].ToString();
                string dt_dep = dataset.Tables[0].Rows[i].ItemArray[6].ToString();
                string status = dataset.Tables[0].Rows[i].ItemArray[7].ToString();
                string airline_name = dataset.Tables[0].Rows[i].ItemArray[9].ToString();
                string cost = dataset.Tables[0].Rows[i].ItemArray[13].ToString();


                DataGridViewRow dataPush = new DataGridViewRow();
                dataPush.CreateCells(viewGrid);
                dataPush.Cells[0].Value = id_flight;
                dataPush.Cells[3].Value = city_arr;
                dataPush.Cells[4].Value = city_dep;
                dataPush.Cells[5].Value = dt_arr;
                dataPush.Cells[6].Value = dt_dep;
                dataPush.Cells[7].Value = status;
                dataPush.Cells[9].Value = airline_name;
                dataPush.Cells[13].Value = cost;

                viewGrid.Rows.Add(dataPush);
            }
            
            conn.Close(); 
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            var str = DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + " \n" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            if (labelTime.InvokeRequired) labelTime.Invoke(new Action<string>((s) => labelTime.Text = s), str);
            else labelTime.Text = str;
        }
    }
}
