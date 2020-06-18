using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        OleDbConnection dbConn;

        String ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;" +
            "Data Source = C:\\Users\\Lonac\\source\\repos\\IS375_Spring_2020\\ON\\DaveLonack\\Module7\\StudentsDB.accdb;" +
            "Persist Security Info=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbConn = new OleDbConnection(ConnectionString);
                dbConn.Open();

                MessageBox.Show("Connection opened Successfully");

                dbConn.Close();
            }
            catch (Exception EX) { MessageBox.Show(EX.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbConn = new OleDbConnection(ConnectionString);
            dbConn.Open();

            String sql;
            sql = "select * From StudentsData;";

            OleDbCommand dbCmd = new OleDbCommand(sql, dbConn);
            OleDbDataReader rd = dbCmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rd);

            dbConn.Close();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbConn = new OleDbConnection(ConnectionString);
            dbConn.Open();

            OleDbCommand command;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            String sql = "";

            sql = "insert into StudentsData (ID, StudentName, CourseCode, TeacherName) values (13, 'Eric Forman', 'IS375', 'Red Forman')";

            command = new OleDbCommand(sql, dbConn);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("Added successfully");

            command.Dispose();
            dbConn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dbConn = new OleDbConnection(ConnectionString);
            dbConn.Open();

            OleDbCommand command;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            String sql = "";

            sql = "delete from StudentsData where StudentName= 'Eric Forman'";

            command = new OleDbCommand(sql, dbConn);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("Deleted successfully");

            command.Dispose();
            dbConn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dbConn = new OleDbConnection(ConnectionString);
            dbConn.Open();

            OleDbCommand command;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            String sql = "";

            sql = "Update StudentsData set StudentName= 'Michael Kelso' where ID=4";

            command = new OleDbCommand(sql, dbConn);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("Record updated successfully");

            command.Dispose();
            dbConn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dbConn = new OleDbConnection(ConnectionString);
            dbConn.Open();

            String sql;
            sql = "select * From StudentsData where StudentName='Bill Mosby';";

            OleDbCommand dbCmd = new OleDbCommand(sql, dbConn);
            OleDbDataReader rd = dbCmd.ExecuteReader();

            DataTable dt = new DataTable();

            dbConn.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
