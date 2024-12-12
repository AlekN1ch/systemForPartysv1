using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandA
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(Form2.nameParty+" Главный организатор");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && comboBox1.Text != string.Empty)
            {
                bool acces = false;
                foreach (var item in comboBox1.Items)
                {
                    if (item.ToString() == comboBox1.Text)
                    {
                        acces = true;
                        break;
                    }
                }
                if (acces)
                {
                    listBox1.Items.Add(textBox1.Text+" "+comboBox1.Text);
                }
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string choice = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(choice);
        }
    }
}
