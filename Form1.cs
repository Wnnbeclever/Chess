using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usr = txtUser.Text;//получаем данные о введенном логине
            string psw = txtPass.Text;//получаем данные о введенном пароле
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=dbUsers.accdb.accdb");//подключаем бд
            cmd = new OleDbCommand();//создаем комманду
            con.Open();
            cmd.Connection = con;//подключаем бд к комманде
            cmd.CommandText = "SELECT * FROM tblUser where user='" + txtUser.Text + "' AND pass='" + txtPass.Text + "'";//ищем строку в бд с совпадающим логином и паролем
            dr = cmd.ExecuteReader();//задаем dr значение выполнение cmd
            if (dr.Read())//cmd выполнилось
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            else//иначе
            {
                MessageBox.Show("Введённый логин или пароль неверен, зарегистрируйтесь");
            }

            con.Close();//отключаем бд
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor=Color.FromArgb(25, 255, 64);
        }
        
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(102, 255, 140);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(25, 255, 64);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(102, 255, 140);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutBox1 a1 = new AboutBox1();
            a1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 reg = new Form2();
            reg.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
