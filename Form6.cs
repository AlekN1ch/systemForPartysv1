using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RandA
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public int rash = 0, balance=0;

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                rash += int.Parse(textBox2.Text);
            }
            catch {
                MessageBox.Show("Неверный формат ввода в поле <<Сумма расходов:>>");
            }
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                bool acces = true;
                
                if (acces)
                {
                    balance = int.Parse(Form4.budj);
                    label5.Text = balance.ToString();
                    if ((balance - rash) <= 0)
                    {
                        MessageBox.Show("Бюджет закончился");
                        button1.Visible = false;
                    }
                    else
                    {
                        label5.Text = Form4.budj;
                        label6.Text = (balance - rash).ToString();
                        listBox1.Items.Add(textBox1.Text + " " + textBox2.Text);
                    }
                    label5.Text = balance.ToString();
                    label6.Text = (balance - rash).ToString();

                }
            }
            
        }
        public void Now()
            {
            balance = int.Parse(Form4.budj);
            label5.Text = balance.ToString();
            label6.Text = (balance - rash).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Now();
        }
    }
}
