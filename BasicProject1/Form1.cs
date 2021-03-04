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


namespace BasicProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conn;

        private void connect()
        {
            try
            {
               // MessageBox.Show(Application.StartupPath);
                var DBPath = Application.StartupPath + "../../../Database\\BasicDb.accdb";
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBPath);
                conn.Open();
            }
            catch (Exception e){
                MessageBox.Show(e.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            string phone, pass;
            phone = maskedTextBox1.Text;
            pass = maskedTextBox2.Text;
            string search= "SELECT * FROM users WHERE phoneNumber = '"+phone.ToString() + "' and WHERE password = '"+ pass.ToString()+"'";
            OleDbCommand command = new OleDbCommand(search,conn);

            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Birdaha Cəhd edin.");
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string phone, pass,name,email;
            phone = maskedTextBox8.Text;
            pass = maskedTextBox7.Text;
            name = maskedTextBox10.Text;
            email = maskedTextBox9.Text;
            string doQuery = "INSERT INTO users (name,email,phoneNumber,password) Values ("+name.ToString()+","+email.ToString()+","+phone.ToString()+","+pass.ToString()+")";
            OleDbCommand command = new OleDbCommand(doQuery, conn);

            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Ready");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Birdaha Cəhd edin.");
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
    }
}

// Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Projeler3\C#\Learning\BasicProject1\Database\BasicDb.accdb

