using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicProject1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int birinci, ikinci,result;
            birinci = Convert.ToInt32(maskedTextBox2.Text);
            ikinci = Convert.ToInt32(maskedTextBox1.Text);
            if (radioButton1.Checked)
            {
                result = birinci * ikinci;
                label2.Text = result.ToString();
                panel1.Visible = true;
            }
            else if (radioButton2.Checked)
            {
                result = birinci + ikinci;
                label2.Text = result.ToString();
                panel1.Visible = true;
            }
            else if (radioButton3.Checked)
            {
                result = birinci / ikinci;
                label2.Text = result.ToString();
                panel1.Visible = true;
            }
            else if (radioButton4.Checked)
            {
                result = birinci - ikinci;
                label2.Text = result.ToString();
                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("Funksiya seçin");
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
