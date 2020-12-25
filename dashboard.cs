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
    public partial class dashboard : Form
    {
        string flag = "AIRPORT";
        string flagDeleteUpdate = "";
        string id = "";
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wisep\source\repos\airlinesystem\Database1.mdf;Integrated Security=True");
        public dashboard()
        {
            InitializeComponent();
            populateGrid();
            selectAttribute.Visible = false;
            newValueBox.Visible = false;
            deleteIDTextBox.Visible = false;
            deletePromptLabel.Visible = false;
            deleteButtonCon.Visible = false;
            label5.Visible = false;
            labelBack.Visible = true;
        }

        private void populateGrid()
        {
            tableNameHeader.Text = flag;
            if (flag == "AIRPORT")
            {
                viewGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Open();
                viewGrid.Columns[0].Visible = true;
                viewGrid.Columns[1].Visible = true;
                viewGrid.Columns[2].Visible = true;
                viewGrid.Columns[3].Visible = true;
                viewGrid.Columns[0].HeaderText = "Аэропорт ID";
                viewGrid.Columns[1].HeaderText = "Название аэропорта";
                viewGrid.Columns[2].HeaderText = "Город";
                viewGrid.Columns[3].HeaderText = "Страна";
                viewGrid.Columns[4].Visible = false;
                viewGrid.Columns[5].Visible = false;
                viewGrid.Columns[6].Visible = false;
                viewGrid.Columns[7].Visible = false;
                viewGrid.Columns[10].Visible = false;
                SqlCommand cmd = new SqlCommand("SELECT * FROM [airport]", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                viewGrid.Rows.Clear();
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
                conn.Close();
            }
            else if (flag == "AIRLINE")
            {
                viewGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Open();
                viewGrid.Columns[0].Visible = true;
                viewGrid.Columns[1].Visible = true;
                viewGrid.Columns[2].Visible = true;
                viewGrid.Columns[0].HeaderText = "Авиакомпания ID";
                viewGrid.Columns[1].HeaderText = "Название авиакомпании";
                viewGrid.Columns[2].HeaderText = "Количество самолётов";
                viewGrid.Columns[3].Visible = false;
                viewGrid.Columns[4].Visible = false;
                viewGrid.Columns[5].Visible = false;
                viewGrid.Columns[6].Visible = false;
                viewGrid.Columns[7].Visible = false;
                viewGrid.Columns[10].Visible = false;
                SqlCommand cmd = new SqlCommand("SELECT * FROM [airline]", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                viewGrid.Rows.Clear();
                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    string id = dataset.Tables[0].Rows[i].ItemArray[0].ToString();
                    string name = dataset.Tables[0].Rows[i].ItemArray[1].ToString();
                    string airplanes = dataset.Tables[0].Rows[i].ItemArray[2].ToString();

                    DataGridViewRow dataPush = new DataGridViewRow();
                    dataPush.CreateCells(viewGrid);
                    dataPush.Cells[0].Value = id;
                    dataPush.Cells[1].Value = name;
                    dataPush.Cells[2].Value = airplanes;
                    viewGrid.Rows.Add(dataPush);
                }
                conn.Close();
            }
            else if (flag == "AIRPLANE")
            {
                viewGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Open();
                viewGrid.Columns[0].Visible = true;
                viewGrid.Columns[1].Visible = true;
                viewGrid.Columns[2].Visible = true;
                viewGrid.Columns[3].Visible = true;
                viewGrid.Columns[4].Visible = true;
                viewGrid.Columns[5].Visible = false;
                viewGrid.Columns[6].Visible = false;
                viewGrid.Columns[7].Visible = false;
                viewGrid.Columns[10].Visible = false;
                viewGrid.Columns[3].HeaderText = "Авиакомпания ID";
                viewGrid.Columns[0].HeaderText = "Самолёт ID";
                viewGrid.Columns[1].HeaderText = "Серийный номер";
                viewGrid.Columns[2].HeaderText = "Количество мест";
                viewGrid.Columns[4].HeaderText = "Категория";
                SqlCommand cmd = new SqlCommand("SELECT * FROM [airplane]", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                viewGrid.Rows.Clear();
                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    string airline_ID = dataset.Tables[0].Rows[i].ItemArray[1].ToString();
                    string id = dataset.Tables[0].Rows[i].ItemArray[0].ToString();
                    string reg = dataset.Tables[0].Rows[i].ItemArray[2].ToString();
                    string seats = dataset.Tables[0].Rows[i].ItemArray[3].ToString();
                    string category = dataset.Tables[0].Rows[i].ItemArray[4].ToString();

                    DataGridViewRow dataPush = new DataGridViewRow();
                    dataPush.CreateCells(viewGrid);
                    dataPush.Cells[0].Value = id;
                    dataPush.Cells[1].Value = reg;
                    dataPush.Cells[2].Value = seats;
                    dataPush.Cells[3].Value = airline_ID;
                    dataPush.Cells[4].Value = category;
                    viewGrid.Rows.Add(dataPush);
                }
                conn.Close();
            }
            else if (flag == "FLIGHT")
            {
                viewGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                conn.Open();
                viewGrid.Columns[0].Visible = true;
                viewGrid.Columns[1].Visible = true;
                viewGrid.Columns[2].Visible = true;
                viewGrid.Columns[3].Visible = true;
                viewGrid.Columns[4].Visible = true;
                viewGrid.Columns[5].Visible = true;
                viewGrid.Columns[6].Visible = true;
                viewGrid.Columns[7].Visible = true;
                viewGrid.Columns[10].Visible = true;
                viewGrid.Columns[0].HeaderText = "Рейс ID";
                viewGrid.Columns[1].HeaderText = "Самолёт ID";
                viewGrid.Columns[2].HeaderText = "Авиакомпания ID";
                viewGrid.Columns[3].HeaderText = "Город прибытия";
                viewGrid.Columns[4].HeaderText = "Город отправления";
                viewGrid.Columns[5].HeaderText = "Время прибытия";
                viewGrid.Columns[6].HeaderText = "Время отправления";
                viewGrid.Columns[7].HeaderText = "Статус";
                viewGrid.Columns[10].HeaderText = "Цена";
                // SELECT* FROM Table1 t1 JOIN Table2 t2 ON t1.USERS = t2.USERS
                SqlCommand cmd = new SqlCommand("SELECT * FROM [flight] JOIN [pay] ON flight.flight_id = pay.flight_id", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                viewGrid.Rows.Clear();
                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    string f_id = dataset.Tables[0].Rows[i].ItemArray[0].ToString();
                    string a_id = dataset.Tables[0].Rows[i].ItemArray[1].ToString();
                    string ar_id = dataset.Tables[0].Rows[i].ItemArray[2].ToString();
                    string d_city = dataset.Tables[0].Rows[i].ItemArray[3].ToString();
                    string a_city = dataset.Tables[0].Rows[i].ItemArray[4].ToString();
                    string d_dt = dataset.Tables[0].Rows[i].ItemArray[5].ToString();
                    string a_dt = dataset.Tables[0].Rows[i].ItemArray[6].ToString();
                    string s = dataset.Tables[0].Rows[i].ItemArray[7].ToString();
                    string pay = dataset.Tables[0].Rows[i].ItemArray[10].ToString();

                    DataGridViewRow dataPush = new DataGridViewRow();
                    dataPush.CreateCells(viewGrid);
                    dataPush.Cells[0].Value = f_id;
                    dataPush.Cells[1].Value = a_id;
                    dataPush.Cells[2].Value = ar_id;
                    dataPush.Cells[3].Value = d_city;
                    dataPush.Cells[4].Value = a_city;
                    dataPush.Cells[5].Value = d_dt;
                    dataPush.Cells[6].Value = a_dt;
                    dataPush.Cells[7].Value = s;
                    dataPush.Cells[10].Value = pay;
                    viewGrid.Rows.Add(dataPush);
                }

                conn.Close();
            }
        }

        public void setID()
        {
            if (flag == "AIRPORT")
            {
                id = "Airport_ID";
                selectAttribute.Items.Clear();
                selectAttribute.Items.AddRange(new object[] {"Airport_Name","City","Country"});
            }
            if (flag == "AIRLINE")
            {
                id = "Airline_ID";
                selectAttribute.Items.Clear();
                selectAttribute.Items.AddRange(new object[] {"Airline_Name","Airplanes"});
            }
            if (flag == "AIRPLANE")
            {
                id = "Airplane_ID";
                selectAttribute.Items.Clear();
                selectAttribute.Items.AddRange(new object[] {"Reg_Number","Seats","Category"});
            }
            if (flag == "FLIGHT")
            {
                id = "Flight_ID";
                selectAttribute.Items.Clear();
                selectAttribute.Items.AddRange(new object[] {"Departure_City","Arrival_City","Departure_DateTime", "Arrival_DateTime", "Status",});
            }
        }

        public void airport()
        {
            flag = "AIRPORT";
            tableNameHeader.Text = "Аэропорты";
            populateGrid();
            setID();
        }

        public void airline()
        {
            flag = "AIRLINE";
            tableNameHeader.Text = "Авиакомпании";
            populateGrid();
            setID();
        }

        public void airplane()
        {
            flag = "AIRPLANE";
            tableNameHeader.Text = "Самолёты";
            populateGrid();
            setID();
        }
        public void flight()
        {
            flag = "FLIGHT";
            tableNameHeader.Text = "Рейсы";
            populateGrid();
            setID();
        }

        private void deleteRecords()
        {
            setID();
            conn.Open();
            string valueTo = deleteIDTextBox.Text;
            if (flag == "AIRLINE")
            {
                SqlCommand cmd1 = new SqlCommand("SELECT Airplane_ID FROM [airplane] WHERE airline_ID=@a", conn);
                cmd1.Parameters.AddWithValue("@a", valueTo);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                adapter.Fill(ds1);
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    string found = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    SqlCommand cmd3 = new SqlCommand("DELETE FROM [flight] WHERE airplane_ID=@aaa", conn);
                    cmd3.Parameters.AddWithValue("@aaa", found);
                    cmd3.ExecuteNonQuery();
                    SqlCommand cmd4 = new SqlCommand("DELETE FROM [aiplane] WHERE airplane_ID=@aa1", conn);
                    cmd4.Parameters.AddWithValue("@aa1", found);
                    cmd4.ExecuteNonQuery();
                }

            }
            else if (flag == "AIRPLANE")
            {
                SqlCommand cmd3 = new SqlCommand("DELETE FROM [flight] WHERE airplane_ID=@aaa", conn);
                cmd3.Parameters.AddWithValue("@aaa", valueTo);
                cmd3.ExecuteNonQuery();
                SqlCommand cmd9 = new SqlCommand("DELETE FROM [aiplane] WHERE " + id + "=@a", conn);
                cmd9.Parameters.AddWithValue("@a", valueTo);
                cmd9.ExecuteNonQuery();
            }

            SqlCommand cmdd = new SqlCommand("DELETE FROM " + flag + " WHERE " + id + "=@a", conn);
            cmdd.Parameters.AddWithValue("@a", valueTo);
            cmdd.ExecuteNonQuery();
            MessageBox.Show("Удалено");
            conn.Close();
            populateGrid();
            deleteIDTextBox.Text = "";
        }

        public void editRecords()
        {
            conn.Open();
            setID();
            string idToUpdated = deleteIDTextBox.Text;
            string newValue = newValueBox.Text;
            string att = selectAttribute.Text;

            SqlCommand cmd = new SqlCommand("UPDATE " + flag + " SET " + att + "=@newVal WHERE " + id + "=@IDUPDate", conn);
            cmd.Parameters.AddWithValue("newVal", newValue);
            cmd.Parameters.AddWithValue("IDUPDate", idToUpdated);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Запись была обновлена!");
            conn.Close();
            populateGrid();
        }

        private void buttonAirport_Click(object sender, EventArgs e)
        {
            //new airport().Show();
            //Hide();
            airport();
        }

        private void buttonAirline_Click(object sender, EventArgs e)
        {
            //new airline().Show();
            //Hide();
            airline();
        }

        private void buttonAirplane_Click(object sender, EventArgs e)
        {
            //new airplane().Show();
            //Hide();
            airplane();
        }

        private void buttonFlight_Click(object sender, EventArgs e)
        {
            //new flight().Show();
            //Hide();
            flight();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new autorisation().Show();
            Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            selectAttribute.Visible = false;
            labelBack.Visible = false;
            newValueBox.Visible = false;
            deleteIDTextBox.Visible = true;
            deletePromptLabel.Visible = true;
            deleteButtonCon.Visible = true;
            label5.Visible = true;
            deleteButtonCon.Text = "Удалить";
            flagDeleteUpdate = "Удалить";
        }
        private void deleteButtonCon_Click(object sender, EventArgs e)
        {
            if (flagDeleteUpdate == "Удалить")
            {
                deleteRecords();
            }
            else if (flagDeleteUpdate == "Обновить")
            {
                editRecords();
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            setID();
            selectAttribute.Visible = true;
            labelBack.Visible = true;
            newValueBox.Visible = true;
            deleteIDTextBox.Visible = true;
            deletePromptLabel.Visible = true;
            deleteButtonCon.Visible = true;
            label5.Visible = true;
            deleteButtonCon.Text = "Обновить";
            flagDeleteUpdate = "Обновить";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (flag == "AIRPORT")
            {
                new airport().Show();
                Hide();
            }
            else if (flag == "AIRLINE")
            {
                new airline().Show();
                Hide();
            }
            else if (flag == "AIRPLANE")
            {
                new airplane().Show();
                Hide();
            }
            else if (flag == "FLIGHT")
            {
                new flight().Show();
                Hide();
            }
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            new autorisation().Show();
            Hide();
        }
    }
}
