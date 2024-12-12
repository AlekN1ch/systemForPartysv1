using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RandA
{
    public partial class Form3 : Form
    {
        public static string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=party.accdb";
        public OleDbConnection myConnection;
        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connection);
            myConnection.Open();
        }
        string name, org, data, time, adress, balance;
        public int money=0;

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partyDataSet.partyTable". При необходимости она может быть перемещена или удалена.
            this.partyTableTableAdapter.Fill(this.partyDataSet.partyTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name =textBox1.Text;
            org =textBox2.Text;
            data =textBox3.Text;
            time =textBox4.Text;
            adress =textBox5.Text;
            balance =money.ToString();
            string query = "INSERT INTO partyTable ([partyName],[partyData],[partyTime],[partyBalance],[partyPlace],[partyLeader]) VALUES " + "('" + name + "','" + data + "','" + time + "','" + balance + "','" + adress + "','" + org + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CkeckBudj();
        }
        public void CkeckBudj()
        {
            try
            {
                 money = int.Parse(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Неккоректный формат ввода в поле <<Бюджет:>>");
            }
        }
    }
}
