using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
             int i = comboBox1.SelectedIndex;
             if (i==-1)
                i = 0;
 
            comboBox1.Items.Insert(i, textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            textBox2.AppendText(string.Format("选中项索引号：{0}\r\n", comboBox1.SelectedIndex));
            if (comboBox1.SelectedIndex != -1)
                textBox2.AppendText(string.Format("选中项内容：{0}\r\n", comboBox1.SelectedItem.ToString()));

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }


    }
}
