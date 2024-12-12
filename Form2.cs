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

namespace RandA
{
    public partial class Form2 : Form
    {
        public static string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=party.accdb";
        public OleDbConnection myConnection;
        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connection);
            myConnection.Open();
        }
        public void Zapoln()
        {
            string query = "SELECT partyName FROM partyTable ORDER BY Код";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();
            string query1 = "SELECT partyData,partyTime,partyBalance,partyPlace,partyLeader FROM partyTable ORDER BY Код";
            OleDbCommand command1 = new OleDbCommand(query1, myConnection);
            OleDbDataReader reader1 = command1.ExecuteReader();
            listBox2.Items.Clear();
            while (reader1.Read())
            {
                listBox2.Items.Add(reader1[0].ToString()+" "+ reader1[1].ToString() + " "+reader1[2].ToString() + " " + reader1[3].ToString() + " "+ reader1[4].ToString() );
            }
            reader1.Close();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partyDataSet.partyTable". При необходимости она может быть перемещена или удалена.
            this.partyTableTableAdapter.Fill(this.partyDataSet.partyTable);
            Zapoln();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zapoln();
            this.partyTableTableAdapter.Fill(this.partyDataSet.partyTable);
            Zapoln();
        }
        public static string nameParty = "";
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameParty = listBox1.SelectedItem.ToString();
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
