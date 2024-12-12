using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RandA
{
    public partial class Form4 : Form
    {
        public static string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=party.accdb";
        public OleDbConnection myConnection;
        public Form4()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connection);
            myConnection.Open();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        public static string budj = "";
        public void LoadZnach()
        {
            string query = "SELECT partyData FROM partyTable WHERE partyName = "+ "('" + name + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
           string data = command.ExecuteScalar().ToString();
            string query1 = "SELECT partyTime FROM partyTable WHERE partyName = " + "('" + name + "')";
            OleDbCommand command1 = new OleDbCommand(query1, myConnection);
            string time = command1.ExecuteScalar().ToString();
            string query2 = "SELECT partyLeader FROM partyTable WHERE partyName = " + "('" + name + "')";
            OleDbCommand command2 = new OleDbCommand(query2, myConnection);
            string org = command2.ExecuteScalar().ToString();
            string query3 = "SELECT partyBalance FROM partyTable WHERE partyName = " + "('" + name + "')";
            OleDbCommand command3 = new OleDbCommand(query3, myConnection);
             budj = command3.ExecuteScalar().ToString();
            string query4 = "SELECT partyPlace FROM partyTable WHERE partyName = " + "('" + name + "')";
            OleDbCommand command4 = new OleDbCommand(query4, myConnection);
            string adress = command4.ExecuteScalar().ToString();
            label11.Text = name;
            label9.Text = org;
            label7.Text = budj;
            label8.Text = adress;
            label12.Text = time;
            label10.Text = data;
        }
        public string name = "";
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partyDataSet.partyTable". При необходимости она может быть перемещена или удалена.
            this.partyTableTableAdapter.Fill(this.partyDataSet.partyTable);
             name  =Form2.nameParty;
            LoadZnach();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string quare = " DELETE FROM  partyTable WHEREpartyName = " + "('" + name + "')";
            OleDbCommand command = new OleDbCommand(quare, myConnection);
            command.ExecuteNonQuery();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }
    }
}
